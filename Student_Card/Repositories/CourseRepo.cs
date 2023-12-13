using Student_Card.Data;
using Student_Card.Interface;
using Student_Card.Models;

namespace Student_Card.Repositories
{
    public class CourseRepo:Repository<Course>,ICourse
    {
        public readonly SqlDbContext _context;

        public CourseRepo(SqlDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(Course entity)
        {
            _context.Courses.Update(entity);
        }
    }
}
