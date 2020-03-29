using System;
using Microsoft.EntityFrameworkCore;
using BS_Start.Models;
namespace BS_Start.Contexts
{
    public class TOSContext: DbContext
    {
        public TOSContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //IN THE CASE OF SEEDING... EXAMPLE:
            //modelBuilder.Entity<Employee>().HasData(
            //    new Employee() { EmployeeId = 1, Name = "John", Designation = "Developer", Address = "New York", CompanyName = "XYZ Inc", Salary = 30000 },
            //    new Employee() { EmployeeId = 2, Name = "Chris", Designation = "Manager", Address = "New York", CompanyName = "ABC Inc", Salary = 50000 },
            //    new Employee() { EmployeeId = 3, Name = "Mukesh", Designation = "Consultant", Address = "New Delhi", CompanyName = "XYZ Inc", Salary = 20000 });
        }

        DbSet<TblOrganizations> TblOrganizations { get; set; }
    }
}
