using StudentEnrollmentSystem.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StudentEnrollmentSystem.ViewModels
{
    public class RegisterViewModel
    {
            // view validations
            [Required]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            
            public int CourseID { get; set; }
            public Course? Course { get; set; }

        
    }
}
