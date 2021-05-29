using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Comanda
    {
        public int Id { get; set; }
        public string Adresa { get; set; }
        public int CosId { get; set; }

        public virtual Cos Cos { get; set; }
    }
}
