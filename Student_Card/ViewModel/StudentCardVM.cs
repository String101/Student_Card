using Student_Card.Models;

namespace Student_Card.ViewModel
{
    public class StudentCardVM
    {
        public IEnumerable<StudentCard> StudentCard { get; set; }

        public string Role { get; set; }
        public IEnumerable<Course> CourseList { get; set; }
    }
}
