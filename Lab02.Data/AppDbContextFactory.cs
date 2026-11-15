using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Lab02.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public static string DatabasePath
    {
        get
        {
            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Lab02EcoStation");
            Directory.CreateDirectory(folder);
            return Path.Combine(folder, "ecostation.db");
        }
    }

    public AppDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlite($"Data Source={DatabasePath}")
            .Options;

        return new AppDbContext(options);
    }
}
