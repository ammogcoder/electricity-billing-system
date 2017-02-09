using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //[Table("Customers")]
    public class Customer : BaseEntity
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int CustomerID { get; set; }
        //[StringLength(50)]
        public string CustomerName { get; set; }
        public string CustomerKey { get; set; }
        public virtual Meter Meter { get; set; }
    }
}
