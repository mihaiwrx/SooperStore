using Microsoft.EntityFrameworkCore;
using ProiectMDS.Contexts;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Services.CategorieService
{
    public class CategorieService:ICategorieService
    {
        public Context _dbcontext { get; set; }

        public CategorieService(Context dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Categorie> Get(int Id)
        {
            return await _dbcontext.Categorii.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<Categorie>> GetAll()
        {
            return await _dbcontext.Categorii.OrderBy(x => x.Nume).ToListAsync();
        }
        public async Task<List<SelectItemDto>> GetAllAsSelect()
        {
            return await _dbcontext.Categorii.Select(x => new SelectItemDto { Value = x.Id, Label = x.Nume }).ToListAsync();
        }


        public async Task Update(Categorie categorie)
        {
            _dbcontext.Update(categorie);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Delete(Categorie categorie)
        {
            _dbcontext.Remove(categorie);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Create(Categorie categorie)
        {
            _dbcontext.Add(categorie);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
