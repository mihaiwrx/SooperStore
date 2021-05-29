using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Recenzie
    {
        public int Id { get; set; }
        public string NumeUtilizator { get; set; }
        public double Nota { get; set; }
        public string Descriere { get; set; }
        public int ProdusId { get; set; }
        public virtual Produs Produs { get; set; }
    }
}
