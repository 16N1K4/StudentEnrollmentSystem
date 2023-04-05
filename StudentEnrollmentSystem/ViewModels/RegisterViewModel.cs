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

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm Password")]
            [Compare("Password", ErrorMessage = "Password and confirm password doesnt match")]
            public string ConfirmPassword { get; set; }

        
    }
}
