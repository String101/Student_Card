using Microsoft.EntityFrameworkCore;
using Student_Card.Data;
using Student_Card.Interface;
using System.Linq.Expressions;
using System.Linq;

namespace Student_Card.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly SqlDbContext _context;
        internal DbSet<T> _dbSet;
        public Repository(SqlDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public bool Any(Expression<Func<T, bool>>? filter)
        {
            return _dbSet.Any(filter);
        }

        public T Get(Expression<Func<T, bool>>? filter, string? includeProperties = null)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties
                  .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp.Trim());
                }

            }
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties
                   .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp.Trim());
                }
            }
            return query.ToList();
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
