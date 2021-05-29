using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Services.ComandaService
{
    public interface IComandaService
    {
        Task<Comanda> Get(int Id);
        Task<List<Comanda>> GetAll();
        Task Update(Comanda comanda);
        Task Delete(Comanda comanda);
        Task Create(Comanda comanda);
    }
}
