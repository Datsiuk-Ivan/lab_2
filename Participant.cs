using System.ComponentModel.DataAnnotations;

namespace Lab02.Data.Entities;

public class Participant
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string FullName { get; set; } = string.Empty;

    public ParticipantRole Role { get; set; }

    public List<Measurement> Measurements { get; set; } = new();
}
