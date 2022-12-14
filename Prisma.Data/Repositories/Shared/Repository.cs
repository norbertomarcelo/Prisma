using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Prisma.Data.Contexts;
using System.Linq.Expressions;

namespace Prisma.Data.Repositories.Shared
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public EntityEntry<T> Insert(T entity)
        {
            var result = _context.Set<T>().Add(entity);
            _context.SaveChanges();

            return result;
        }

        public T? Select(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> Select()
        {
            return _context.Set<T>().ToList();
        }

        public IEnumerable<T> Select(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
