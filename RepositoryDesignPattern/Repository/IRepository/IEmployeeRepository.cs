using RepositoryDesignPattern.DAL.DTOs;
using RepositoryDesignPattern.Repository.Base;

namespace RepositoryDesignPattern.Repository.IRepository
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
    }
}
