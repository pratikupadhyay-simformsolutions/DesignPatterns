using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.Repository.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetById(int id);

        IEnumerable<T> GetAll();

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
