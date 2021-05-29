using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Permisie
    {
        public int Id { get; set; }
        public int Nume { get; set; }
        public string Descriere { get; set; }
        public List<RolXPermisie> rolPermisie { get; set; } = new List<RolXPermisie>();
    }
}
