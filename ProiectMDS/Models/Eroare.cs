using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Eroare
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Detalii { get; set; }
        public DateTime Data { get; set; }
    }
}
