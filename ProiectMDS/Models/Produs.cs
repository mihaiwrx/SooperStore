using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Produs
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public int Stoc { get; set; }
        public double Pret { get; set; }
        public int FurnizorId { get; set; }
        public int CategorieId { get; set; }

        public virtual Furnizor Furnizor { get; set; }
        public virtual Categorie Categorie { get; set; }
    }
}
