using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Entities.EFCodeFirstMappings
{
    public class OrderMap:EntityTypeConfiguration<Order>
    {
       public OrderMap()
        {
            this.HasKey(o => o.OrderId);//Primary Key
            
            this.Property(o=>o.ProductName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("ProductName");

            this.Property(o => o.ProductId)
                .IsRequired()
                .HasColumnName("ProductId");
            this.Property(o=>o.OrderDate)
                .IsRequired()
                .HasColumnName("OrderDate");

            this.ToTable("Orders");//Veritabanında Orders tablosu oluşturur.
            
            //this.HasOptional(o=> o.customers)//HasOptional() yazmazsak CustomerId alanı null olamaz.
            //    .WithMany(o=>o.Orders)//Customer ile Order arasında 1-N ilişki var.
            //    .HasForeignKey(f=>f.customers.CustomerId);//ForeignKey

        }
    }
}
