using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data.Entity.ModelConfiguration;
namespace DAL.Mapping
{
    public class ConsumptionMap : EntityTypeConfiguration<Consumption>
    {
        public ConsumptionMap()
        {
            HasKey(t => t.ID);
            Property(t => t.Month).IsRequired();
            Property(t => t.Year).IsRequired();
            Property(t => t.CurrentReading).IsRequired();
            Property(t => t.PreviousReading).IsRequired();
            Property(t => t.MeterID).IsRequired();
            Property(t => t.ConsumptionEnergy).IsRequired();
            Property(t => t.UnitPrice).IsRequired();
            Property(t => t.Date).IsRequired();

            ToTable("Consumption");

            HasRequired(t => t.Meter).WithMany(c => c.Consumptions).HasForeignKey(f =>f.MeterID);
        }
    }
}
