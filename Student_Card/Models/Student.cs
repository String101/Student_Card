using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Student_Card.Models
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Student Number")]
        public string? Student_Number { get; set; }
        [ForeignKey("Course")]
        [Display(Name = "Enrollment")]
        public int CourseId { get; set; }
        [ValidateNever]
        public Course Course { get; set; }
        public string Title { get; set; }
        public string Initials { get; set; }
        public string Surname { get; set; }
    }
}
