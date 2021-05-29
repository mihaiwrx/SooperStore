using ProiectMDS.DTOs;
using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Services.CategorieService
{
    public interface ICategorieService
    {
        Task<Categorie> Get(int Id);
        Task<List<Categorie>> GetAll();
        Task Update(Categorie categorie);
        Task Delete(Categorie categorie);
        Task Create(Categorie categorie);
        Task<List<SelectItemDto>> GetAllAsSelect();
    }
}
