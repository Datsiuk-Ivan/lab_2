using Lab02.Data.Entities;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Lab02.Data.Services;

public class InstrumentService : ServiceBase
{
    private const string DuplicateSerialMessage = "Прилад із таким серійним номером уже існує. Перевірте номер.";

    public List<Instrument> GetAll()
    {
        try
        {
            using var db = CreateContext();
            return db.Instruments
                .Include(i => i.Calibrations)
                .OrderBy(i => i.Name)
                .ToList();
        }
        catch (SqliteException ex)
        {
            throw new DataOperationException(ReadErrorMessage, ex);
        }
    }

    public void Add(Instrument instrument)
    {
        Validate(instrument);
        using var db = CreateContext();
        db.Instruments.Add(new Instrument
        {
            Name = instrument.Name.Trim(),
            Type = instrument.Type,
            SerialNumber = instrument.SerialNumber.Trim(),
            Status = instrument.Status
        });
        Save(db, DuplicateSerialMessage, "Не вдалося зберегти прилад.");
    }

    public void Update(Instrument instrument)
    {
        Validate(instrument);
        using var db = CreateContext();
        var existing = db.Instruments.Find(instrument.Id)
            ?? throw new DataOperationException("Прилад не знайдено. Можливо, його вже видалено.");

        existing.Name = instrument.Name.Trim();
        existing.Type = instrument.Type;
        existing.SerialNumber = instrument.SerialNumber.Trim();
        existing.Status = instrument.Status;
        Save(db, DuplicateSerialMessage, "Не вдалося зберегти прилад.");
    }

    public void Delete(int id)
    {
        using var db = CreateContext();
        var existing = db.Instruments.Find(id)
            ?? throw new DataOperationException("Прилад не знайдено. Можливо, його вже видалено.");

        db.Instruments.Remove(existing);
        Save(db, DuplicateSerialMessage,
            "Неможливо видалити прилад: за ним збережено виміри, а наукові дані не можна втратити. Прилад, який уже використовувався, виводять з роботи статусом «Retired».");
    }

    private static void Validate(Instrument instrument)
    {
        var errors = new List<string>();
        CheckText(errors, instrument.Name, "Назва приладу", 100, true);
        CheckText(errors, instrument.SerialNumber, "Серійний номер", 50, true);

        if (errors.Count > 0)
            throw new DataValidationException(errors);
    }
}