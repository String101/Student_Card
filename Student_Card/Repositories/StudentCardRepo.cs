using Student_Card.Data;
using Student_Card.Interface;
using Student_Card.Models;

namespace Student_Card.Repositories
{
    public class StudentCardRepo:Repository<StudentCard>,IStudentCard
    {
        public readonly SqlDbContext _context;

        public StudentCardRepo(SqlDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(StudentCard entity)
        {
            _context.StudentCards.Update(entity);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
