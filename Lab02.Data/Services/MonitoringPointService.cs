using Lab02.Data.Entities;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Lab02.Data.Services;

public class MonitoringPointService : ServiceBase
{
    private const string DuplicateCodeMessage = "Точка з таким кодом уже існує. Вкажіть інший код.";
    private const string MissingLocationMessage = "Вибрана місцевість не існує. Оновіть список і виберіть іншу.";

    public List<MonitoringPoint> GetAll()
    {
        try
        {
            using var db = CreateContext();
            return db.MonitoringPoints
                .Include(p => p.Location)
                .OrderBy(p => p.Code)
                .ToList();
        }
        catch (SqliteException ex)
        {
            throw new DataOperationException(ReadErrorMessage, ex);
        }
    }

    public void Add(MonitoringPoint point)
    {
        Validate(point);
        using var db = CreateContext();
        db.MonitoringPoints.Add(new MonitoringPoint
        {
            LocationId = point.LocationId,
            Code = point.Code.Trim(),
            Purpose = point.Purpose,
            PlannedLatitude = point.PlannedLatitude,
            PlannedLongitude = point.PlannedLongitude
        });
        Save(db, DuplicateCodeMessage, MissingLocationMessage);
    }

    public void Update(MonitoringPoint point)
    {
        Validate(point);
        using var db = CreateContext();
        var existing = db.MonitoringPoints.Find(point.Id)
            ?? throw new DataOperationException("Точку не знайдено. Можливо, її вже видалено.");

        existing.LocationId = point.LocationId;
        existing.Code = point.Code.Trim();
        existing.Purpose = point.Purpose;
        existing.PlannedLatitude = point.PlannedLatitude;
        existing.PlannedLongitude = point.PlannedLongitude;
        Save(db, DuplicateCodeMessage, MissingLocationMessage);
    }

    public void Delete(int id)
    {
        using var db = CreateContext();
        var existing = db.MonitoringPoints.Find(id)
            ?? throw new DataOperationException("Точку не знайдено. Можливо, її вже видалено.");

        db.MonitoringPoints.Remove(existing);
        Save(db, DuplicateCodeMessage,
            "Неможливо видалити точку: у ній уже зафіксовано виміри. Наукові дані не можна втратити.");
    }

    private static void Validate(MonitoringPoint point)
    {
        var errors = new List<string>();
        CheckText(errors, point.Code, "Код точки", 20, true);

        if (point.LocationId <= 0)
            errors.Add("Виберіть місцевість.");
        if (point.PlannedLatitude < -90 || point.PlannedLatitude > 90)
            errors.Add("Планова широта має бути в межах від -90 до 90.");
        if (point.PlannedLongitude < -180 || point.PlannedLongitude > 180)
            errors.Add("Планова довгота має бути в межах від -180 до 180.");

        if (errors.Count > 0)
            throw new DataValidationException(errors);
    }
}