using Student_Card.Models;

namespace Student_Card.Interface
{
    public interface ICourse:IRepository<Course>
    {
        void Update(Course entity);
    }
}
