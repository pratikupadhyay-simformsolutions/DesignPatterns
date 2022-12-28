using System.Collections.Generic;

namespace RepositoryDesignPattern.DAL.DTOs
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        
        private ICollection<Employee> _employee { get; set; }

        public virtual ICollection<Employee> Employee
        {
            get => _employee ??= new HashSet<Employee>();
            set=> _employee = value;
        }
    }
}
