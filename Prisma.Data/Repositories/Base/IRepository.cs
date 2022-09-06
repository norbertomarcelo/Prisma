﻿using System.Linq.Expressions;

namespace Prisma.Data.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        T? Select(int id);
        IEnumerable<T> Select();
        IEnumerable<T> Select(Expression<Func<T, bool>> expression);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
