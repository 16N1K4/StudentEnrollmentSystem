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
        public List<Subject>? Subjects { get; set; }

        public Faculty()
        {

        }

    }
}
