using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace hospital.Models
{
    public class Department
    {
        [Key]
        public int Department_ID { get; set; }

        public string Department_Name { get; set; } = "";
        public string? Description { get; set; }
        public List<Doctor> Doctor { get; set; } = new();

    }
}
