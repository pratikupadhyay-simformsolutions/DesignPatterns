using RepositoryDesignPattern.DAL;
using RepositoryDesignPattern.DAL.DTOs;
using RepositoryDesignPattern.Repository.Base;
using RepositoryDesignPattern.Repository.IRepository;

namespace RepositoryDesignPattern.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
