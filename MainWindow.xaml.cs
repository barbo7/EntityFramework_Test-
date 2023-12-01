using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp3.Contexts;
using WpfApp3.Entities;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
            label1.Content = i;
            using (var db = new DenemeContext())
            {
                ////Veri Ekleme
                //var customer = new Customer { CustomerName = "Test", CustomerId=1, CustomerPhone="5543123254"};
                //db.Customers.Add(customer);
                //db.SaveChanges();

                ////Relationlu veri Ekleme
                //var customer = db.Customers.Find(1);
                //customer.Orders.Add(new Order { ProductId = 2, ProductName = "Laptop", OrderDate = DateTime.Now });
                //db.SaveChanges();

                ////Veri Silme
                //var customer = db.Customers.Find(3);
                //db.Customers.Remove(customer);
                //db.SaveChanges();

                ////Veri Güncelleme
                //Customer customer  = db.Customers.Find(1);
                //customer.CustomerName = "Bora";
                //db.SaveChanges();


            }
        }
        private void Button1_Click(object Sender, EventArgs e)
        {
            label1.Content = i++;

        }
    }
}
