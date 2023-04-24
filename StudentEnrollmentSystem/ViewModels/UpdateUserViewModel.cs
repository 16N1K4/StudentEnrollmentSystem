using Microsoft.AspNetCore.Mvc;
using StudentEnrollmentSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentSystem.ViewModels
{
    public class UpdateUserViewModel
    {
        public string Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string OldEmail { get; set; }
        [Required]
        [EmailAddress]
        [Remote(action: "VerifyNewEmail", controller: "Account", AdditionalFields = "OldEmail", ErrorMessage = "A user with this email address already exists.")]
        public string NewEmail { get; set; }
        [Required(ErrorMessage = "The 'Course' field is required")]
        public int CourseID { get; set; }
        public Course? Course { get; set; }
    }
}
