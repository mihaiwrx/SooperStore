using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Services.CosService
{
    public interface ICosService
    {
        Task<Cos> Get(int Id);
        Task<List<Cos>> GetAll();

        Task Update(Cos cos);

        Task Delete(Cos cos);

        Task Create(Cos cos);
    }
}
