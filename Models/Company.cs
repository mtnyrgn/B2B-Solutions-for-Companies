using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace b2b.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get;set; }
        public string CompanyName { get;set; }
        public string CompanyTel{ get;set;}

    }
}
