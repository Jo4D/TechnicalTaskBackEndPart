using Microsoft.EntityFrameworkCore;
using TechnicalTask.Data.Models;
namespace TechnicalTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { set; get; }
    }
}