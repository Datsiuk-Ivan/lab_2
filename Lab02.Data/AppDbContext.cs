using Lab02.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab02.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Location> Locations => Set<Location>();
    public DbSet<MonitoringPoint> MonitoringPoints => Set<MonitoringPoint>();
    public DbSet<Instrument> Instruments => Set<Instrument>();
    public DbSet<Participant> Participants => Set<Participant>();
    public DbSet<Measurement> Measurements => Set<Measurement>();
    public DbSet<Calibration> Calibrations => Set<Calibration>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Location>().Property(l => l.Type).HasConversion<string>();
        modelBuilder.Entity<MonitoringPoint>().Property(p => p.Purpose).HasConversion<string>();
        modelBuilder.Entity<Instrument>().Property(i => i.Type).HasConversion<string>();
        modelBuilder.Entity<Instrument>().Property(i => i.Status).HasConversion<string>();
        modelBuilder.Entity<Participant>().Property(p => p.Role).HasConversion<string>();

        modelBuilder.Entity<Measurement>()
            .Property(m => m.Status)
            .HasConversion<string>()
            .HasDefaultValue(MeasurementStatus.Valid);

        modelBuilder.Entity<MonitoringPoint>()
            .HasOne(p => p.Location)
            .WithMany(l => l.MonitoringPoints)
            .HasForeignKey(p => p.LocationId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Measurement>()
            .HasOne(m => m.MonitoringPoint)
            .WithMany(p => p.Measurements)
            .HasForeignKey(m => m.MonitoringPointId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Measurement>()
            .HasOne(m => m.Instrument)
            .WithMany(i => i.Measurements)
            .HasForeignKey(m => m.InstrumentId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Measurement>()
            .HasOne(m => m.Participant)
            .WithMany(p => p.Measurements)
            .HasForeignKey(m => m.ParticipantId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
