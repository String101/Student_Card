namespace Student_Card.Interface
{
    public interface IUnitOfWork
    {
        IStudent Student { get; }
        ICourse Course { get; }
        IStudentCard StudentCard { get; }
        IApplicationUser User { get; }
        void Save();
    }
}
