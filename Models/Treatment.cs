using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hospital.Models
{
    public class Treatment
    {
        public int Doctor_ID { get; set; }

        public int Patient_ID { get; set; }

        public string? Diagnosis { get; set; }

        [ForeignKey("Doctor_ID")]
        public Doctor? Doctor { get; set; }

        [ForeignKey("Patient_ID")]
        public Patient? Patient { get; set; }
    }
}