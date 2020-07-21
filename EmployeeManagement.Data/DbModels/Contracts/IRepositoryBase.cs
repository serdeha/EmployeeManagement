
using System;
using System.Linq;
using System.Linq.Expressions;

namespace EmployeeManagement.Data.DbModels.Contracts
{
    public interface IRepositoryBase<T> where T : class, new() // sadece newlene bilen classlar bu kalıtıma sahip olabilir diyoruz.
    {
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null);
        T Get(int id);
        T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
