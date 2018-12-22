using _08___DataAccessInMVCUsingEntityFramework.Models;
using System.Data.Entity;

namespace _08___DataAccessInMVCUsingEntityFramework.Contexts
{
    public class EmployeeContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}