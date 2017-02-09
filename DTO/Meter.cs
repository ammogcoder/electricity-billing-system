using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //[Table("Meters")]
    public class Meter : BaseEntity
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int MeterID { get; set; }
        //[StringLength(50)]
       
        //public int CustomerX { get; set; }
      
        public string MeterKey { get; set; }
        
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Consumption> Consumptions { get; set; }
    }
}