using System.ComponentModel.DataAnnotations;

public class Patient
{
    [Key]
    public int Patient_ID { get; set; }

    [Required]
    public string Name { get; set; } = "";

    [Range(1, 120)]
    public int Age { get; set; }

    [Required]
    public string Gender { get; set; } = "";

    public string? Disease { get; set; }
}