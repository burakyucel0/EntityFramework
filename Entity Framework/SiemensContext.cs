using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Entity_Framework
{
    public class SiemensContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS; Database = Efdb; Trusted_Connection = True; ");

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }
        public DbSet<CustomerDemographics> CustomerDemographics { get; set; }
        public DbSet<Customers> customers { get; set; }
        public DbSet<Employees> employees { get; set; }
        public DbSet<EmployeeTerritories> employeeTerritories { get; set; }
        public DbSet<Order_Details> order_Details { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Region> regions   { get; set; }
        public DbSet<Shippers> shippers { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<Territories> territories { get; set; }
        }
}
