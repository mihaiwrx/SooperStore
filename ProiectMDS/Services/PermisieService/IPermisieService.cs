using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Services.PermisieService
{
    public interface IPermisieService
    {
        Task<Permisie> Get(int Id);
        Task<List<Permisie>> GetAll();

        Task Update(Permisie permisie);

        Task Delete(Permisie permisie);

        Task Create(Permisie permisie);
    }
}
