using Microsoft.AspNetCore.Mvc;
using StudentEnrollmentSystem.Data;
using StudentEnrollmentSystem.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
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
            [Remote(action: "CheckDuplicateEmail", controller: "Account", ErrorMessage = "A user with this email address already exists.")]
            public string Email { get; set; }
            
            public int CourseID { get; set; }
            public Course? Course { get; set; }

    }
}
