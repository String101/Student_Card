using Student_Card.Models;

namespace Student_Card.Interface
{
    public interface IStudent:IRepository<Student>
    {
        void Update(Student entity);
    }
}
