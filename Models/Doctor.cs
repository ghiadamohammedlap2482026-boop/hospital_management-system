using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hospital.Models
{
    public class Doctor
    {
        [Key]
        public int Doctor_ID { get; set; }

        public string Name { get; set; } = "";

        public int Age { get; set; }
        public string? Email { get; set; }
        public String Phone { get; set; } = "";

        public Decimal Salary { get; set; }
        [ForeignKey("Department")]

        public int? Department_ID { get; set; }
        public Department? Department { get; set; }



    }
}
