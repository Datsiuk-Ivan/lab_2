using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Lab02.Data.Entities;

[Index(nameof(Code), IsUnique = true)]
public class MonitoringPoint
{
    public int Id { get; set; }
    public int LocationId { get; set; }

    [MaxLength(20)]
    public string Code { get; set; } = string.Empty;

    public PointPurpose Purpose { get; set; }
    public double PlannedLatitude { get; set; }
    public double PlannedLongitude { get; set; }

    public Location? Location { get; set; }
    public List<Measurement> Measurements { get; set; } = new();
}
