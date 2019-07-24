using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace b2b.Models
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public bool CargoState { get; set; }
        public int OrderId { get; set; }
        public string CargoAdress { get; set; }
        public virtual Order Order { get; set; }   

    }
}
