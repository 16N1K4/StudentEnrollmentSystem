using Microsoft.AspNetCore.Identity;

namespace StudentEnrollmentAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentNumber { get; set; }
        public int CourseID { get; set; }
        public Course? Course { get; set; }
        public List<StudentSubject>? Subjects { get; set; }
    }
}
