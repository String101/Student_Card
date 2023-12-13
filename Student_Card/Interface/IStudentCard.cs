using Student_Card.Models;

namespace Student_Card.Interface
{
    public interface IStudentCard:IRepository<StudentCard>
    {
        void Update(StudentCard entity);
    }
}
