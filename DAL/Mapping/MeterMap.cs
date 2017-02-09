using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DTO;
using DAL;

namespace DAL.Mapping
{
    public class MeterMap : EntityTypeConfiguration<Meter>
    {
        public MeterMap()
        {       
            //key
            HasKey(t => t.ID);
            //properties
            Property(t => t.MeterKey).IsRequired();

            ToTable("Meters");
            //HasRequired(t => t.Customer).WithRequiredDependent(u => u.Meter).WithMany(c => c.Consumption);
            //HasRequired(t => t.Customer).WithRequiredDependent(m => m.Meter);
            //HasMany(t => t.Consumptions).WithRequired(m => m.Meter);
            
        }
    }
}

