using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace b2b.Models
{
    public class Order
    {
     
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string ProductDesc { get; set; }
        public int ProductCount { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }    


    }
}
