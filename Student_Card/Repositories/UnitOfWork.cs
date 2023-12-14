using Student_Card.Data;
using Student_Card.Interface;

namespace Student_Card.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly SqlDbContext _db;

        public IStudent Student { get;private set; }
        public ICourse Course { get; private set; }
        public IStudentCard StudentCard { get; private set; }
        public IApplicationUser User { get; private set; }
        public UnitOfWork(SqlDbContext db)
        {
            _db = db;
            Student= new StudentRepo(_db);
            StudentCard= new StudentCardRepo(_db);
            Course= new CourseRepo(_db);
            User= new ApplicationUserRepo(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
