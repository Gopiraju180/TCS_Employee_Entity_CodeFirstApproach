using Microsoft.EntityFrameworkCore;
using TCS_Employee_Entity_CodeFirstApproach.Entites;
namespace TCS_Employee_Entity_CodeFirstApproach
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public DbSet<Employee> employees { get; set; }

        public DbSet<Orders>orderss { get; set; }

        public DbSet<Departement> departements { get; set; }

    }
}
