using RepositoryDesignPattern.DAL;
using RepositoryDesignPattern.DAL.DTOs;
using RepositoryDesignPattern.Repository.Base;
using RepositoryDesignPattern.Repository.IRepository;

namespace RepositoryDesignPattern.Repository
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository 
    {
        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
