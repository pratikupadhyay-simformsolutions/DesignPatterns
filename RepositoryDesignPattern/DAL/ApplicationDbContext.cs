using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern.DAL.DTOs;
using System;

namespace RepositoryDesignPattern.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Employee> Employee { get; set; }   
        public DbSet<Department> Department { get; set; }
    }
}
