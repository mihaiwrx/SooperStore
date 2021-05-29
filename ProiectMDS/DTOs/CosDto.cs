using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.DTOs
{
    public class CosDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProdusId { get; set; }

        public string NumeUser { get; set; }

        public string NumeProdus { get; set; }
    }
}
