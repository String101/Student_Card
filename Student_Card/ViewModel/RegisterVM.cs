using System.ComponentModel.DataAnnotations;

namespace Student_Card.ViewModel
{
    public class RegisterVM
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        public string RedirectUrl { get; set; }

        [Display(Name = "Enrollment")]
        public int CourseNumber { get; set; }
        public string Title { get; set; }
        public string Initials { get; set; }
        public string Surname { get; set; }
        public string StudentNumber { get; set; }
    }
}
