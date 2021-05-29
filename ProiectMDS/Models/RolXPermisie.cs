using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class RolXPermisie
    {
        public int Id { get; set; }
        public int RolId { get; set; }
        public int PermisieId { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual Permisie Permisie { get; set; }
    }
}
