using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Student_Card.ViewModel
{
    public class RegisterViewM
    {
        public RegisterVM RegisterVM { get; set; }
        public IEnumerable<SelectListItem> CourseList { get; set; }
        public string Role { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> Roles { get; set; }

    }
}
