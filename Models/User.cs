using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace b2b.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public bool UserRole { get; set; }

    }
}
