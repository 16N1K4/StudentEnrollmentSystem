using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentAPI.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int DeptID { get; set; }
        public Department? Department { get; set; }
        public List<ApplicationUser>? Students { get; set; }
        public List<Subject>? Subjects { get; set; }

        public Course()
        {

        }

        public Course(int id, string name, int deptID)
        {
            ID = id;
            Name = name;
            DeptID = deptID;
        }
    }
}
