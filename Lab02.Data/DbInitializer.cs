using Lab02.Data.Entities;
using Lab02.Data.Services;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Lab02.Data;

public static class DbInitializer
{
    public static void Initialize()
    {
        try
        {
            using var db = new AppDbContextFactory().CreateDbContext([]);
            db.Database.Migrate();

            if (db.Locations.Any())
                return;

            SeedData(db);
        }
        catch (SqliteException ex)
        {
            throw new DataOperationException("Не вдалося відкрити базу даних. Перевірте, що файл бази доступний і не відкритий в іншій програмі.", ex);
        }
        catch (DbUpdateException ex)
        {
            throw new DataOperationException("Не вдалося заповнити базу початковими даними.", ex);
        }
    }

    private static void SeedData(AppDbContext db)
    {
        var upperRiver = new Location { Name = "Верхня ділянка до впадіння струмка", Type = LocationType.River, Description = "Швидка течія, кам'янисте дно" };
        var middleRiver = new Location { Name = "Середина річки з повільною течією", Type = LocationType.River, Description = "Заплава, пік цвітіння влітку" };
        var belowDam = new Location { Name = "Ділянка нижче греблі", Type = LocationType.River };
        var tributary = new Location { Name = "Притока з болотом", Type = LocationType.River, Description = "Торф'яне дно, низький кисень" };
        var pineForest = new Location { Name = "Сосняк на пісках", Type = LocationType.Forest };
        var alderForest = new Location { Name = "Вільшняк біля заплави", Type = LocationType.Forest, Description = "Сезонне підтоплення" };
        var controlHill = new Location { Name = "Контрольна площа на пагорбі", Type = LocationType.Forest };
        db.Locations.AddRange(upperRiver, middleRiver, belowDam, tributary, pineForest, alderForest, controlHill);

        var pointUpS = new MonitoringPoint { Location = upperRiver, Code = "R-UP-S1", Purpose = PointPurpose.Sensor, PlannedLatitude = 50.7412, PlannedLongitude = 25.3108 };
        var pointUpW = new MonitoringPoint { Location = upperRiver, Code = "R-UP-W1", Purpose = PointPurpose.Sampling, PlannedLatitude = 50.7415, PlannedLongitude = 25.3114 };
        var pointMidS = new MonitoringPoint { Location = middleRiver, Code = "R-MID-S1", Purpose = PointPurpose.Sensor, PlannedLatitude = 50.7368, PlannedLongitude = 25.3221 };
        var pointMidW = new MonitoringPoint { Location = middleRiver, Code = "R-MID-W1", Purpose = PointPurpose.Sampling, PlannedLatitude = 50.7371, PlannedLongitude = 25.3229 };
        var pointDamW = new MonitoringPoint { Location = belowDam, Code = "R-DAM-W1", Purpose = PointPurpose.Sampling, PlannedLatitude = 50.7322, PlannedLongitude = 25.3347 };
        var pointTribS = new MonitoringPoint { Location = tributary, Code = "R-TRB-S1", Purpose = PointPurpose.Sensor, PlannedLatitude = 50.7389, PlannedLongitude = 25.3402 };
        var pointPineS = new MonitoringPoint { Location = pineForest, Code = "F-PIN-S1", Purpose = PointPurpose.Sensor, PlannedLatitude = 50.7503, PlannedLongitude = 25.2987 };
        var pointPineC = new MonitoringPoint { Location = pineForest, Code = "F-PIN-C1", Purpose = PointPurpose.CameraTrap, PlannedLatitude = 50.7511, PlannedLongitude = 25.2979 };
        var pointAlderS = new MonitoringPoint { Location = alderForest, Code = "F-ALD-S1", Purpose = PointPurpose.Sensor, PlannedLatitude = 50.7381, PlannedLongitude = 25.3165 };
        var pointHillS = new MonitoringPoint { Location = controlHill, Code = "F-HIL-S1", Purpose = PointPurpose.Sensor, PlannedLatitude = 50.7552, PlannedLongitude = 25.3051 };
        db.MonitoringPoints.AddRange(pointUpS, pointUpW, pointMidS, pointMidW, pointDamW, pointTribS, pointPineS, pointPineC, pointAlderS, pointHillS);

        var multiparameter = new Instrument { Name = "Мультипараметр YSI ProDSS", Type = InstrumentType.Multiparameter, SerialNumber = "YSI-21A0457", Status = InstrumentStatus.Active };
        var spareMultiparameter = new Instrument { Name = "Мультипараметр Hanna HI98194", Type = InstrumentType.Multiparameter, SerialNumber = "HI-98194-0331", Status = InstrumentStatus.InRepair };
        var oxygenLogger = new Instrument { Name = "Логер кисню HOBO U26", Type = InstrumentType.Logger, SerialNumber = "HOBO-U26-7781", Status = InstrumentStatus.Active };
        var soilSensor = new Instrument { Name = "Датчик ґрунтової вологи TEROS 12", Type = InstrumentType.SoilSensor, SerialNumber = "TER-12-5530", Status = InstrumentStatus.Active };
        var thermohygrometer = new Instrument { Name = "Термогігрометр Testo 608", Type = InstrumentType.Thermohygrometer, SerialNumber = "TST-608-1194", Status = InstrumentStatus.Active };
        var cameraTrap = new Instrument { Name = "Фотопастка Browning Recon", Type = InstrumentType.CameraTrap, SerialNumber = "BRN-RF-2207", Status = InstrumentStatus.Active };
        var oldLogger = new Instrument { Name = "Логер температури старий", Type = InstrumentType.Logger, SerialNumber = "LOG-OLD-0012", Status = InstrumentStatus.Retired };
        db.Instruments.AddRange(multiparameter, spareMultiparameter, oxygenLogger, soilSensor, thermohygrometer, cameraTrap, oldLogger);

        db.Calibrations.AddRange(
            new Calibration { Instrument = multiparameter, CalibratedAt = new DateTime(2026, 6, 1, 7, 10, 0), Method = "pH на двох буферах (4.01 і 7.00)", IsPassed = true },
            new Calibration { Instrument = multiparameter, CalibratedAt = new DateTime(2026, 7, 14, 6, 50, 0), Method = "Кисень на повітрі", IsPassed = true },
            new Calibration { Instrument = multiparameter, CalibratedAt = new DateTime(2026, 9, 2, 7, 5, 0), Method = "Провідність на стандарті 1413 мкСм/см", IsPassed = true },
            new Calibration { Instrument = spareMultiparameter, CalibratedAt = new DateTime(2026, 8, 20, 8, 0, 0), Method = "pH на двох буферах (прострочений розчин)", IsPassed = false },
            new Calibration { Instrument = oxygenLogger, CalibratedAt = new DateTime(2026, 6, 30, 18, 30, 0), Method = "Кисень на повітрі", IsPassed = true },
            new Calibration { Instrument = soilSensor, CalibratedAt = new DateTime(2026, 5, 15, 9, 0, 0), Method = "Заводська перевірка на еталонному ґрунті", IsPassed = true });

        var researcher = new Participant { FullName = "Олена Коваль", Role = ParticipantRole.Researcher };
        var seniorResearcher = new Participant { FullName = "Андрій Мельник", Role = ParticipantRole.Researcher };
        var student = new Participant { FullName = "Марія Ткачук", Role = ParticipantRole.Student };
        var entomologyStudent = new Participant { FullName = "Денис Бондар", Role = ParticipantRole.Student };
        var volunteer = new Participant { FullName = "Ірина Савчук", Role = ParticipantRole.Volunteer };
        var newVolunteer = new Participant { FullName = "Тарас Гнатюк", Role = ParticipantRole.Volunteer };
        db.Participants.AddRange(researcher, seniorResearcher, student, entomologyStudent, volunteer, newVolunteer);

        db.Measurements.AddRange(
            new Measurement { MonitoringPoint = pointUpW, Instrument = multiparameter, Participant = researcher, MeasuredAt = new DateTime(2026, 6, 1, 8, 15, 0), Parameter = "Температура води", Value = 16.4, Unit = "°C", Depth = 0.3 },
            new Measurement { MonitoringPoint = pointUpW, Instrument = multiparameter, Participant = researcher, MeasuredAt = new DateTime(2026, 6, 1, 8, 17, 0), Parameter = "pH", Value = 7.6, Unit = "од. pH", Depth = 0.3 },
            new Measurement { MonitoringPoint = pointUpW, Instrument = multiparameter, Participant = student, MeasuredAt = new DateTime(2026, 6, 1, 8, 20, 0), Parameter = "pH", Value = 7.5, Unit = "од. pH", Depth = 0.3, IsControl = true, Note = "Контрольний дубль" },
            new Measurement { MonitoringPoint = pointUpW, Instrument = multiparameter, Participant = researcher, MeasuredAt = new DateTime(2026, 6, 1, 8, 24, 0), Parameter = "Електропровідність", Value = 412, Unit = "мкСм/см", Depth = 0.3 },
            new Measurement { MonitoringPoint = pointMidW, Instrument = multiparameter, Participant = researcher, MeasuredAt = new DateTime(2026, 7, 14, 7, 40, 0), Parameter = "Розчинений кисень", Value = 8.1, Unit = "мг/л", Depth = 0.5 },
            new Measurement { MonitoringPoint = pointMidW, Instrument = multiparameter, Participant = student, MeasuredAt = new DateTime(2026, 7, 14, 7, 45, 0), Parameter = "Розчинений кисень", Value = 8.0, Unit = "мг/л", Depth = 0.5, IsControl = true, Note = "Контрольний дубль" },
            new Measurement { MonitoringPoint = pointMidW, Instrument = multiparameter, Participant = researcher, MeasuredAt = new DateTime(2026, 7, 14, 7, 50, 0), Parameter = "Хлорофіл", Value = 24.7, Unit = "мкг/л", Depth = 0.5, Note = "Пік цвітіння" },
            new Measurement { MonitoringPoint = pointMidS, Instrument = oxygenLogger, Participant = seniorResearcher, MeasuredAt = new DateTime(2026, 7, 15, 2, 0, 0), Parameter = "Розчинений кисень", Value = 3.2, Unit = "мг/л", Depth = 0.4, Note = "Нічний провал кисню" },
            new Measurement { MonitoringPoint = pointMidS, Instrument = oxygenLogger, Participant = seniorResearcher, MeasuredAt = new DateTime(2026, 7, 15, 3, 0, 0), Parameter = "Розчинений кисень", Value = 0.4, Unit = "мг/л", Depth = 0.4, Status = MeasurementStatus.Suspicious, Note = "Логер показував error, хвиля била по мембрані" },
            new Measurement { MonitoringPoint = pointMidS, Instrument = oxygenLogger, Participant = seniorResearcher, MeasuredAt = new DateTime(2026, 7, 15, 4, 0, 0), Parameter = "Розчинений кисень", Value = 14.9, Unit = "мг/л", Depth = 0.4, Status = MeasurementStatus.Suspicious, Note = "Стрибок сигналу після забризкування сенсора" },
            new Measurement { MonitoringPoint = pointMidS, Instrument = oxygenLogger, Participant = seniorResearcher, MeasuredAt = new DateTime(2026, 7, 17, 3, 0, 0), Parameter = "Розчинений кисень", Value = 2.9, Unit = "мг/л", Depth = 0.4, Note = "Повторна ніч після перезакріплення логера" },
            new Measurement { MonitoringPoint = pointDamW, Instrument = multiparameter, Participant = volunteer, MeasuredAt = new DateTime(2026, 9, 2, 9, 10, 0), Parameter = "Мутність", Value = 18.3, Unit = "NTU", Depth = 0.2 },
            new Measurement { MonitoringPoint = pointDamW, Instrument = multiparameter, Participant = researcher, MeasuredAt = new DateTime(2026, 9, 2, 9, 15, 0), Parameter = "pH", Value = 12.8, Unit = "од. pH", Depth = 0.2, Status = MeasurementStatus.Suspicious, Note = "Можлива кислотна пляшка без промивання" },
            new Measurement { MonitoringPoint = pointTribS, Instrument = multiparameter, Participant = researcher, MeasuredAt = new DateTime(2026, 4, 18, 10, 30, 0), Parameter = "Температура води", Value = 9.8, Unit = "°C", Depth = 0.3, ActualLatitude = 50.7392, ActualLongitude = 25.3409, RelocationReason = "Паводок: датчик тимчасово перенесено на 6 м вище за течією" },
            new Measurement { MonitoringPoint = pointTribS, Instrument = multiparameter, Participant = researcher, MeasuredAt = new DateTime(2026, 4, 18, 10, 35, 0), Parameter = "Розчинений кисень", Value = 5.1, Unit = "мг/л", Depth = 0.3, ActualLatitude = 50.7392, ActualLongitude = 25.3409, RelocationReason = "Паводок: датчик тимчасово перенесено на 6 м вище за течією" },
            new Measurement { MonitoringPoint = pointUpS, Instrument = multiparameter, Participant = seniorResearcher, MeasuredAt = new DateTime(2026, 4, 19, 11, 0, 0), Parameter = "Температура води", Value = 10.2, Unit = "°C", Depth = 0.3, ActualLatitude = 50.7414, ActualLongitude = 25.3101, RelocationReason = "Високий рівень води, перенесено ближче до берегової віхи" },
            new Measurement { MonitoringPoint = pointUpS, Instrument = multiparameter, Participant = seniorResearcher, MeasuredAt = new DateTime(2026, 5, 20, 11, 0, 0), Parameter = "Температура води", Value = 13.6, Unit = "°C", Depth = 0.3 },
            new Measurement { MonitoringPoint = pointPineS, Instrument = soilSensor, Participant = student, MeasuredAt = new DateTime(2026, 9, 10, 12, 0, 0), Parameter = "Вологість ґрунту", Value = 11.4, Unit = "%", Depth = 0.1 },
            new Measurement { MonitoringPoint = pointPineS, Instrument = soilSensor, Participant = student, MeasuredAt = new DateTime(2026, 9, 10, 12, 10, 0), Parameter = "Температура ґрунту", Value = 14.2, Unit = "°C", Depth = 0.2 },
            new Measurement { MonitoringPoint = pointAlderS, Instrument = soilSensor, Participant = entomologyStudent, MeasuredAt = new DateTime(2026, 9, 10, 13, 30, 0), Parameter = "Вологість ґрунту", Value = 38.9, Unit = "%", Depth = 0.1 },
            new Measurement { MonitoringPoint = pointAlderS, Instrument = thermohygrometer, Participant = volunteer, MeasuredAt = new DateTime(2026, 9, 10, 13, 40, 0), Parameter = "Відносна вологість повітря", Value = 87, Unit = "%" },
            new Measurement { MonitoringPoint = pointHillS, Instrument = soilSensor, Participant = entomologyStudent, MeasuredAt = new DateTime(2026, 9, 11, 10, 0, 0), Parameter = "Вологість ґрунту", Value = 17.6, Unit = "%", Depth = 0.1 },
            new Measurement { MonitoringPoint = pointHillS, Instrument = thermohygrometer, Participant = newVolunteer, MeasuredAt = new DateTime(2026, 9, 11, 10, 15, 0), Parameter = "Температура повітря", Value = 41.5, Unit = "°C", Status = MeasurementStatus.Suspicious, Note = "Прилад лежав на сонці, перевірити" },
            new Measurement { MonitoringPoint = pointPineC, Instrument = cameraTrap, Participant = volunteer, MeasuredAt = new DateTime(2026, 9, 17, 9, 0, 0), Parameter = "Кадри з косулями", Value = 14, Unit = "шт." },
            new Measurement { MonitoringPoint = pointPineC, Instrument = cameraTrap, Participant = volunteer, MeasuredAt = new DateTime(2026, 9, 17, 9, 5, 0), Parameter = "Кадри з лисицями", Value = 3, Unit = "шт." },
            new Measurement { MonitoringPoint = pointUpW, Instrument = oldLogger, Participant = seniorResearcher, MeasuredAt = new DateTime(2026, 3, 28, 9, 0, 0), Parameter = "Температура води", Value = 5.7, Unit = "°C", Depth = 0.3, Note = "Останній вимір перед списанням логера" });

        db.SaveChanges();
    }
}
