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
            Student= new StudentRepo(db);
            StudentCard= new StudentCardRepo(db);
            Course= new CourseRepo(db);
            User= new ApplicationUserRepo(db);
        }
        public void Save()
        {
          _db.SaveChanges();
        }
    }
}
