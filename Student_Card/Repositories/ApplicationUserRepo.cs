using Student_Card.Data;
using Student_Card.Interface;
using Student_Card.Models;

namespace Student_Card.Repositories
{
    public class ApplicationUserRepo: Repository<ApplicationUser>, IApplicationUser
    {
        public readonly SqlDbContext _context;

        public ApplicationUserRepo(SqlDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
