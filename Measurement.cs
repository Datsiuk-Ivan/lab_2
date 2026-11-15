using System.ComponentModel.DataAnnotations;

namespace Lab02.Data.Entities;

public class Measurement
{
    public int Id { get; set; }
    public int MonitoringPointId { get; set; }
    public int InstrumentId { get; set; }
    public int ParticipantId { get; set; }
    public DateTime MeasuredAt { get; set; }

    [MaxLength(50)]
    public string Parameter { get; set; } = string.Empty;

    public double Value { get; set; }

    [MaxLength(20)]
    public string Unit { get; set; } = string.Empty;

    public double? Depth { get; set; }
    public bool IsControl { get; set; }
    public double? ActualLatitude { get; set; }
    public double? ActualLongitude { get; set; }

    [MaxLength(200)]
    public string? RelocationReason { get; set; }

    public MeasurementStatus Status { get; set; }

    [MaxLength(500)]
    public string? Note { get; set; }

    public MonitoringPoint? MonitoringPoint { get; set; }
    public Instrument? Instrument { get; set; }
    public Participant? Participant { get; set; }
}
