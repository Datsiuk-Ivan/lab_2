using Lab02.Data.Entities;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Lab02.Data.Services;

public class MeasurementService : ServiceBase
{
    private const string MissingRelatedMessage = "Вибрана точка, прилад або учасник уже не існує. Оновіть список і виберіть знову.";

    public List<Measurement> GetAll()
    {
        try
        {
            using var db = CreateContext();
            return db.Measurements
                .Include(m => m.MonitoringPoint)
                .Include(m => m.Instrument)
                .Include(m => m.Participant)
                .OrderByDescending(m => m.MeasuredAt)
                .ToList();
        }
        catch (SqliteException ex)
        {
            throw new DataOperationException(ReadErrorMessage, ex);
        }
    }

    public List<Measurement> GetSuspicious()
    {
        try
        {
            using var db = CreateContext();
            return db.Measurements
                .Include(m => m.MonitoringPoint)
                .Include(m => m.Instrument)
                .Include(m => m.Participant)
                .Where(m => m.Status == MeasurementStatus.Suspicious)
                .OrderByDescending(m => m.MeasuredAt)
                .ToList();
        }
        catch (SqliteException ex)
        {
            throw new DataOperationException(ReadErrorMessage, ex);
        }
    }

    public void Add(Measurement measurement)
    {
        Validate(measurement);
        using var db = CreateContext();
        var newMeasurement = new Measurement();
        CopyValues(measurement, newMeasurement);
        db.Measurements.Add(newMeasurement);
        Save(db, "Не вдалося зберегти вимір.", MissingRelatedMessage);
    }

    public void Update(Measurement measurement)
    {
        Validate(measurement);
        using var db = CreateContext();
        var existing = db.Measurements.Find(measurement.Id)
            ?? throw new DataOperationException("Вимір не знайдено. Можливо, його вже видалено.");

        CopyValues(measurement, existing);
        Save(db, "Не вдалося зберегти вимір.", MissingRelatedMessage);
    }

    public void Delete(int id)
    {
        using var db = CreateContext();
        var existing = db.Measurements.Find(id)
            ?? throw new DataOperationException("Вимір не знайдено. Можливо, його вже видалено.");

        db.Measurements.Remove(existing);
        Save(db, "Не вдалося видалити вимір.", "Не вдалося видалити вимір.");
    }

    private static void CopyValues(Measurement source, Measurement target)
    {
        target.MonitoringPointId = source.MonitoringPointId;
        target.InstrumentId = source.InstrumentId;
        target.ParticipantId = source.ParticipantId;
        target.MeasuredAt = source.MeasuredAt;
        target.Parameter = source.Parameter.Trim();
        target.Value = source.Value;
        target.Unit = source.Unit.Trim();
        target.Depth = source.Depth;
        target.IsControl = source.IsControl;
        target.ActualLatitude = source.ActualLatitude;
        target.ActualLongitude = source.ActualLongitude;
        target.RelocationReason = string.IsNullOrWhiteSpace(source.RelocationReason) ? null : source.RelocationReason.Trim();
        target.Status = source.Status;
        target.Note = string.IsNullOrWhiteSpace(source.Note) ? null : source.Note.Trim();
    }

    private static void Validate(Measurement measurement)
    {
        var errors = new List<string>();

        if (measurement.MonitoringPointId <= 0)
            errors.Add("Виберіть точку виміру.");
        if (measurement.InstrumentId <= 0)
            errors.Add("Виберіть прилад.");
        if (measurement.ParticipantId <= 0)
            errors.Add("Виберіть учасника.");
        if (measurement.MeasuredAt > DateTime.Now)
            errors.Add("Дата виміру не може бути в майбутньому.");

        CheckText(errors, measurement.Parameter, "Параметр", 50, true);
        CheckText(errors, measurement.Unit, "Одиниця виміру", 20, true);
        CheckText(errors, measurement.RelocationReason, "Причина перенесення", 200, false);
        CheckText(errors, measurement.Note, "Примітка", 500, false);

        if (measurement.Depth < 0)
            errors.Add("Глибина не може бути від'ємною.");

        bool hasLatitude = measurement.ActualLatitude.HasValue;
        bool hasLongitude = measurement.ActualLongitude.HasValue;
        bool hasReason = !string.IsNullOrWhiteSpace(measurement.RelocationReason);

        if (hasLatitude != hasLongitude || hasLatitude != hasReason)
            errors.Add("Для перенесеного датчика заповніть обидві фактичні координати і причину перенесення, або залиште всі три поля порожніми.");
        if (measurement.ActualLatitude < -90 || measurement.ActualLatitude > 90)
            errors.Add("Фактична широта має бути в межах від -90 до 90.");
        if (measurement.ActualLongitude < -180 || measurement.ActualLongitude > 180)
            errors.Add("Фактична довгота має бути в межах від -180 до 180.");

        if (errors.Count > 0)
            throw new DataValidationException(errors);
    }
}