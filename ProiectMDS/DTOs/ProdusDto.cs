using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.DTOs
{
    public class ProdusDto
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public int Stoc { get; set; }
        public double Pret { get; set; }
        public int FurnizorId { get; set; }
        public int CategorieId { get; set; }

        public string NumeFurnizor { get; set; }
        public string NumeCategorie { get; set; }
    }
}
