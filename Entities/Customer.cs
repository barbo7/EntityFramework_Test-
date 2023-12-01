using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Entities
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
        }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public List<Order> Orders { get; set; } 
    }
}
