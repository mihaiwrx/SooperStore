using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public int? RolId { get; set; }
        public string NumeRol { get; set; }
    }
}
