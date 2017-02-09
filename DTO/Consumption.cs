using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Consumption : BaseEntity
    {
        //public int ConsumptionID { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int CurrentReading { get; set; }
        public int PreviousReading { get; set; }
        public int MeterID { get; set; }
        public int ConsumptionEnergy { get; set; }
        public int UnitPrice { get; set; }
        public DateTime Date { get; set; }
        public virtual Meter Meter { get; set; }
    }
}
