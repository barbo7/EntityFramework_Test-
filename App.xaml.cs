using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using WpfApp3.Contexts;
using System.Windows;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

       

            // Veritabanı oluşturucu
            Database.SetInitializer(new CreateDatabaseIfNotExists<DenemeContext>());

            using (var context = new DenemeContext())
            {
                context.Database.CreateIfNotExists(); //database yoksa oluşturuluyor.
            }
        }
    }
}
