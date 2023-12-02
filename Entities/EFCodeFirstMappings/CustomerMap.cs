using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.Entities;

namespace WpfApp3.Entities.EFCodeFirstMappings
{
    public class CustomerMap:EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            this.HasKey(a => a.CustomerId);//Primary Key 

            this.Property(a => a.CustomerName)
                .IsRequired()//IsRequired() yazmazsak CustomerName alanı null olabilir.
                .HasMaxLength(50) //MaxLength(50) yazımı da aynı işi görür.
                .HasColumnName("CustomerName"); //Veritabanında CustomerName alanının adını CustomerName olarak değiştirir böylece herhangi bir değişiklik yapmadan veritabanı ile eşleşir.

            this.Property(a => a.CustomerPhone)
                .HasMaxLength(10) //MaxLength(10) yazımı da aynı işi görür. 
                .HasColumnName("CustomerPhone"); 

        }
    }
}
