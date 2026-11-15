using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Lab02.Data.Entities;

[Index(nameof(SerialNumber), IsUnique = true)]
public class Instrument
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    public InstrumentType Type { get; set; }

    [MaxLength(50)]
    public string SerialNumber { get; set; } = string.Empty;

    public InstrumentStatus Status { get; set; }

    public List<Measurement> Measurements { get; set; } = new();
    public List<Calibration> Calibrations { get; set; } = new();
}