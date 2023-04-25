using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentAPI.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public List<Faculty>? Faculties { get; set; }
        public List<Course>? Courses { get; set; }

        public Department()
        {

        }
    }
}
