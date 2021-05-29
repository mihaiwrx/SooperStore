using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Rol
    {
        public int Id { get; set; }
        public string Nume { get; set; }

        public List<RolXPermisie> rolPermisie { get; set; } = new List<RolXPermisie>();

    }
}
