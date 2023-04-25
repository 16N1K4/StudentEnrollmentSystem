using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentSystem.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "The 'Name' field is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The 'Department' field is required")]
        public int DeptID { get; set; }
        public Department? Department { get; set; }
        public List<ApplicationUser>? Students { get; set; }
        public List<Subject>? Subjects { get; set; }

        public Course()
        {

        }
    }
}
