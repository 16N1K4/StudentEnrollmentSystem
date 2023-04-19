using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "The 'First Name' field is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "The 'Last Name' field is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "The 'Course' field is required")]
        public int CourseID { get; set; }
        public Course? Course { get; set; }
        public List<StudentSubject>? Subjects { get; set; }
    }
}
