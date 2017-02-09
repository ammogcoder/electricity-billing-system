using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DTO;
using DAL;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            //key
            HasKey(t => t.ID);
            //properties
            Property(t => t.CustomerName).IsRequired();
            Property(t => t.CustomerKey).IsRequired();
            ToTable("Customers");
            //HasRequired(t => t.Meter).WithRequiredDependent(u => u.Customer);
            HasRequired(t => t.Meter).WithRequiredDependent(u => u.Customer);
        }
    }
}
