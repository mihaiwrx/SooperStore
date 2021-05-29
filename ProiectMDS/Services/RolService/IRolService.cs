using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Services.RolService
{
    public interface IRolService
    {
        Task<Rol> Get(int Id);
        Task<List<Rol>> GetAll();
        Task Update(Rol rol);
        Task Delete(Rol rol);
        Task Create(Rol rol);
    }
}
