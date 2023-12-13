using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Student_Card.Models;

namespace Student_Card.ViewModel
{
    public class StudentVM
    {
        public Student Student { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CourseList { get; set; }
    }
    
}
