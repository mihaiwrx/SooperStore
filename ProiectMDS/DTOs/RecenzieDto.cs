using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.DTOs
{
    public class RecenzieDto
    {
        public int Id { get; set; }
        public string NumeUtilizator { get; set; }
        public double Nota { get; set; }
        public string Descriere { get; set; }
        public int ProdusId { get; set; }
        public string NumeProdus { get; set; }
    }
}
