using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentAPI.Models
{
    public class Faculty
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string? FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public int DeptID { get; set; }
        public Department? Department { get; set; }
        public List<Subject>? Subjects { get; set; }

        public Faculty()
        {

        }

        public Faculty(int id, string firstName, string lastName, string email, int deptID, string fullName)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DeptID = deptID;
            FullName = fullName;
        }
    }
}
