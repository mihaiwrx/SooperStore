using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Services.ProdusService
{
    public interface IProdusService
    {
        Task<Produs> Get(int Id);
        Task<List<Produs>> GetAll();
        Task Update(Produs produs);
        Task Delete(Produs produs);
        Task Create(Produs produs);
    }
}
