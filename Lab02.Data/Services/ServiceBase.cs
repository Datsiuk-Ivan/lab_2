using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Lab02.Data.Services;

public abstract class ServiceBase
{
    protected const string ReadErrorMessage = "Не вдалося прочитати дані з бази. Перевірте, що файл бази доступний.";

    protected static AppDbContext CreateContext()
    {
        return new AppDbContextFactory().CreateDbContext([]);
    }

    protected static void Save(AppDbContext db, string uniqueMessage, string foreignKeyMessage)
    {
        try
        {
            db.SaveChanges();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw new DataOperationException("Запис уже змінено або видалено. Оновіть список і повторіть дію.", ex);
        }
        catch (DbUpdateException ex)
        {
            string reason = ex.InnerException?.Message ?? "";

            if (reason.Contains("UNIQUE constraint failed"))
                throw new DataOperationException(uniqueMessage, ex);

            if (reason.Contains("FOREIGN KEY constraint failed"))
                throw new DataOperationException(foreignKeyMessage, ex);

            throw new DataOperationException("Не вдалося зберегти зміни в базі даних.", ex);
        }
        catch (SqliteException ex)
        {
            throw new DataOperationException("Немає доступу до бази даних. Перевірте, що файл бази не відкритий в іншій програмі.", ex);
        }
    }

    protected static void CheckText(List<string> errors, string? value, string fieldName, int maxLength, bool required)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            if (required)
                errors.Add($"Поле «{fieldName}» обов'язкове.");
            return;
        }

        if (value.Trim().Length > maxLength)
            errors.Add($"Поле «{fieldName}» не може бути довшим за {maxLength} символів.");
    }
}