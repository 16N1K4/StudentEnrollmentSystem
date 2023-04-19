using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentSystem.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "The 'Name' field is required")]
        public string Name { get; set; }
        public List<Faculty>? Faculties { get; set; }
        public List<Course>? Courses { get; set; } 

        public Department()
        {

        }

        public Department(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
