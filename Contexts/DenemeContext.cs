using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.Entities;
namespace WpfApp3.Contexts
{
    public class DenemeContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Order> Orders { get; set; }
    }
}
