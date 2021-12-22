using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using _Task_08__ASM1.Models;

namespace ASM1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<_Task_08__ASM1.Models.Category> Category { get; set; }
        public DbSet<_Task_08__ASM1.Models.Product> Product { get; set; }
    }
}