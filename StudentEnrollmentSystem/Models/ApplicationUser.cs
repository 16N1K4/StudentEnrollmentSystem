using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace StudentEnrollmentSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CourseID { get; set; }
        public Course? Course { get; set; }
        public List<StudentSubject>? Subjects { get; set; }
    }
}
