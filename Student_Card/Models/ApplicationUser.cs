using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Student_Card.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string StudentNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Enrollment")]
        public int CourseNumber { get; set; }
        public string Title { get; set; }
        public string Initials { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
    }
}

