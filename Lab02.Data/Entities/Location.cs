using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Lab02.Data.Entities;

[Index(nameof(Name), IsUnique = true)]
public class Location
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    public LocationType Type { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }

    public List<MonitoringPoint> MonitoringPoints { get; set; } = new();
}