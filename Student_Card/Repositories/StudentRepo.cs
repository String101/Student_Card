using Student_Card.Data;
using Student_Card.Interface;
using Student_Card.Models;

namespace Student_Card.Repositories
{
    public class StudentRepo:Repository<Student>,IStudent
    {
        public readonly SqlDbContext _context;

        public StudentRepo(SqlDbContext context):base(context)
        {
            _context = context;
        }
        public void Update(Student entity)
        {
            _context.Students.Update(entity);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
