using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Student_Card.Models
{
    public class StudentCard
    {
        [Key,]
        public int Id { get; set; }
        [ValidateNever]
        public int Year { get; set; } = DateTime.Now.Year;

        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        [ForeignKey("Student")]
        [Display(Name = "Student Number")]
        public string StudentID { get; set; }
        [ValidateNever]
        public Student Student { get; set; }
     
        public string Course { get; set; }
        public string Status { get; set; } = SD.StatusPending;
    }
}
