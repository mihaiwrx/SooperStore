using ProiectMDS.DTOs;
using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Services.FurnizorService
{
    public interface IFurnizorService
    {
        Task<Furnizor> Get(int Id);
        Task<List<Furnizor>> GetAll();
        Task Update(Furnizor furnizor);
        Task Delete(Furnizor furnizor);
        Task Create(Furnizor furnizor);

        Task<List<SelectItemDto>> GetAllSelect();
    }
}
