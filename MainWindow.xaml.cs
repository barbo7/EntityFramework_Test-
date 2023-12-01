using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                //for(int i=0;i<15;i++)
                //{
                //    var customer = new Customer { CustomerName = $"Test{i}", CustomerPhone = "5543123254" };
                //    db.Customers.Add(customer);
                //    customer.Orders.Add(new Order { OrderDate = DateTime.Now, ProductId = i, ProductName = $"Urun{i}" });
                //}

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

                ////Veri Listeleme
                //IQueryable<Customer> customers = (from a in db.Customers
                //           //where a.CustomerName == "Bora" kod yapısı sql ile birebir aynı neredeyse ve 
                //          select a); //burada birden fazla veri çekmek için select new ( a.CustomerName, a.CustomerPhone) yapısı kullanılır
                //foreach (Customer item in customers)
                //{
                //    TextBlock textBlock = new TextBlock();
                //    textBlock.Text = $"Veri {item.CustomerName}";
                //    stackPanel.Children.Add(textBlock);
                //}

                ////Yukarıdaki kodun aynısı
                //var result = from a in db.Customers
                //             select a.CustomerName;
                //foreach(var i in result)
                //{
                //    TextBlock textBlock = new TextBlock();
                //    textBlock.Text = $"Veri {i}";
                //    stackPanel.Children.Add(textBlock);
                //}   

                ////Groupby ile veri listeleme koşullu şekilde
                //var result = from c in db.Customers
                //             group c by c.CustomerName into g
                //             where g.Key.StartsWith("B")
                //             select  g;
                //foreach(var i in result)
                //{
                //    TextBlock textBlock = new TextBlock();
                //    textBlock.Text = $" {i.Key}";
                //    stackPanel.Children.Add(textBlock);
                //}

                //Order by ile veri listeleme
                //var result = from c in db.Customers
                //             orderby c.CustomerName descending
                //             select c;
                //foreach (var i in result)
                //{
                //    TextBlock textBlock = new TextBlock();
                //    textBlock.Text = $" {i.CustomerName}";
                //    stackPanel.Children.Add(textBlock);
                //}

                ////Join ile veri listeleme
                //var result = from c in db.Customers
                //             join o in db.Orders on c.CustomerId equals o.customers.CustomerId
                //             select new { c.CustomerName, o.ProductName };
                //foreach (var i in result)
                //{
                //    TextBlock textBlock = new TextBlock();
                //    textBlock.Text = $" {i.CustomerName} {i.ProductName}";
                //    stackPanel.Children.Add(textBlock);
                //}




            }
        }
        private void Button1_Click(object Sender, EventArgs e)
        {
            label1.Content = i++;

        }
    }
}
