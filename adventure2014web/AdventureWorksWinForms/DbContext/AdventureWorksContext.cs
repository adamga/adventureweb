using Microsoft.EntityFrameworkCore;

namespace AdventureWorksWinForms.DbContext
{
    public class AdventureWorksContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<HumanResources.vEmployee> Employees { get; set; }
        public DbSet<HumanResources.vEmployeeDepartment> EmployeeDepartments { get; set; }
        public DbSet<HumanResources.vEmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
        public DbSet<Sales.vIndividualCustomer> IndividualCustomers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionStringHere");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HumanResources.vEmployee>().HasNoKey().ToView("vEmployee", "HumanResources");
            modelBuilder.Entity<HumanResources.vEmployeeDepartment>().HasNoKey().ToView("vEmployeeDepartment", "HumanResources");
            modelBuilder.Entity<HumanResources.vEmployeeDepartmentHistory>().HasNoKey().ToView("vEmployeeDepartmentHistory", "HumanResources");
            modelBuilder.Entity<Sales.vIndividualCustomer>().HasNoKey().ToView("vIndividualCustomer", "Sales");
        }
    }
}
