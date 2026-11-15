using System.ComponentModel.DataAnnotations;

namespace Lab02.Data.Entities;

public class Calibration
{
    public int Id { get; set; }
    public int InstrumentId { get; set; }
    public DateTime CalibratedAt { get; set; }

    [MaxLength(100)]
    public string Method { get; set; } = string.Empty;

    public bool IsPassed { get; set; }

    public Instrument? Instrument { get; set; }
}
