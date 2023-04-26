using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentSystem.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "The 'Name' field is required")]
        public string Name { get; set; }
        public List<Course>? Courses { get; set; } 

        public Department()
        {

        }
    }
}
