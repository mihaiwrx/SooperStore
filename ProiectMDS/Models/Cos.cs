using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Cos
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProdusId { get; set; }

        public virtual User User { get; set; }

        public virtual Produs Produs { get; set; }

    }
}
