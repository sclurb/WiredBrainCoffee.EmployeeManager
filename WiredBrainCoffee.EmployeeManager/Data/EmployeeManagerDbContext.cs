using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.EmployeeManager.Data.Models;

namespace WiredBrainCoffee.EmployeeManager.Data
{
    public class EmployeeManagerDbContext : DbContext
    {
        public EmployeeManagerDbContext(DbContextOptions<EmployeeManagerDbContext> options) : base(options) { }
        public DbSet<Employee> Employee => Set<Employee>();
        public DbSet<Department> Department => Set<Department>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Finanace" },
                new Department { Id = 2, Name = "Sales" },
                new Department { Id = 3, Name = "Marketing" },
                new Department { Id = 4, Name = "Human Resources" },
                new Department { Id = 5, Name = "IT" }
                );
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Firstname = "Anna", Lastname = "Rockstar", DepartmentId = 2 },
                new Employee { Id = 2, Firstname = "Julia", Lastname = "Developer", DepartmentId = 5, IsDeveloper = true },
                new Employee { Id = 3, Firstname = "Thomas", Lastname = "Huber", DepartmentId = 5, IsDeveloper = true },
                new Employee { Id = 4, Firstname = "Sara", Lastname = "Metroid", DepartmentId = 1 },
                new Employee { Id = 5, Firstname = "Ben", Lastname = "Rockstar", DepartmentId = 4 },
                new Employee { Id = 6, Firstname = "Alex", Lastname = "Rider", DepartmentId = 3, IsDeveloper = true },
                new Employee { Id = 7, Firstname = "Sophie", Lastname = "Ramos", DepartmentId = 5 },
                new Employee { Id = 8, Firstname = "Julien", Lastname = "Russel", DepartmentId = 2 },
                new Employee { Id = 9, Firstname = "Yvonne", Lastname = "Snider", DepartmentId = 4 },
                new Employee { Id = 10, Firstname = "Jasmin", Lastname = "Curtis", DepartmentId = 1, IsDeveloper = true }
                );
        }
    }
}
