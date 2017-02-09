using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConsumptionModel
    {
        public int ID { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int CurrentReading { get; set; }
        public int PreviousReading { get; set; }
        public string MeterKey { get; set; }
        public int MeterID { get; set; }
        public int ConsumptionEnergy { get; set; }
        public int UnitPrice { get; set; }
        public DateTime Date { get; set; }
        //[Display(Name="Customer Name")]
        public string CustomerName { get; set; }
    }
}
