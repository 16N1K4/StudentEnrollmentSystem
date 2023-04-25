using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentSystem.Models
{
    public class Faculty
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "The 'First Name' field is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The 'Last Name' field is required")]
        public string LastName { get; set; }

        public string? FullName { get; set; }

        [Required(ErrorMessage = "The 'Email Address' field is required")]
        [EmailAddress(ErrorMessage = "This is not a valid email address")]
        public string Email { get; set; }
        public List<Subject>? Subjects { get; set; }

        public Faculty()
        {

        }
    }
}
