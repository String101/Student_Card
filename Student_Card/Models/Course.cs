using System.ComponentModel.DataAnnotations;

namespace Student_Card.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Course")]
        public string CourseName { get; set; }
        [Display(Name = "Course Details")]
        public string CourseDescription { get; set; }
        [Display(Name = "Code")]
        public string CourseCode { get; set; }
    }
}
