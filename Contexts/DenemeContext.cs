using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.Entities;
using WpfApp3.Entities.EFCodeFirstMappings;
namespace WpfApp3.Contexts
{
    public class DenemeContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderMap());
        }
    }
}
