using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentSystem.Models
{
    public class Section
    {
        [Key]
        public int ID { get; set; }
        public string? SectionCode { get; set; }
        [Required(ErrorMessage = "Day is a required field")]
        [Remote(action: "DuplicateSchedule", controller: "Section", AdditionalFields = "StartTime, EndTime", ErrorMessage = "A section with this exact schedule already exists.")]
        public string Day { get; set; }
        [Required(ErrorMessage = "Start Time is a required field")]
        [Remote(action: "CheckStartEndTime", controller: "Section", AdditionalFields = "EndTime", ErrorMessage = "The start time cannot be later or equal to the end time.")]
        public string StartTime { get; set; }
        [Required(ErrorMessage = "End time is a required field")]
        [Remote(action: "AllowedTimeSpan", controller: "Section", AdditionalFields = "StartTime", ErrorMessage = "The class must be at least one hour long, but not longer than three hours.")]
        public string EndTime { get; set; }
        public string? FullSchedule { get; set; }
        public List<Subject>? Subjects { get; set; }

        public Section()
        {

        }
    }
}
