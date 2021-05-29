using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Services.RecenzieService
{
    public interface IRecenzieService
    {
        Task<Recenzie> Get(int Id);
        Task<List<Recenzie>> GetAll();

        Task Update(Recenzie recenzie);

        Task Delete(Recenzie recenzie);

        Task Create(Recenzie recenzie);

        Task<List<Recenzie>> GetAllByProductId(long id);
    }
}
