using Microsoft.EntityFrameworkCore;
namespace Humman_Resources_Management.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> EmployeeItems { get; set; }
    }
}
