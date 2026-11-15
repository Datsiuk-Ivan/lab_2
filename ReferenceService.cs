using Lab02.Data.Entities;
using Microsoft.Data.Sqlite;

namespace Lab02.Data.Services;

public class ReferenceService : ServiceBase
{
    public List<Location> GetLocations()
    {
        try
        {
            using var db = CreateContext();
            return db.Locations.OrderBy(l => l.Name).ToList();
        }
        catch (SqliteException ex)
        {
            throw new DataOperationException(ReadErrorMessage, ex);
        }
    }

    public List<Participant> GetParticipants()
    {
        try
        {
            using var db = CreateContext();
            return db.Participants.OrderBy(p => p.FullName).ToList();
        }
        catch (SqliteException ex)
        {
            throw new DataOperationException(ReadErrorMessage, ex);
        }
    }
}