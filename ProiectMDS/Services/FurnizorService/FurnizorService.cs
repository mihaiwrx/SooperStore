using Microsoft.EntityFrameworkCore;
using ProiectMDS.Contexts;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Services.FurnizorService
{
    public class FurnizorService:IFurnizorService
    {
        public Context _dbcontext { get; set; }

        public FurnizorService(Context dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Furnizor> Get(int Id)
        {
            return await _dbcontext.Furnizori.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<Furnizor>> GetAll()
        {
            return await _dbcontext.Furnizori.OrderBy(x => x.Nume).ToListAsync();
        }
        public async Task<List<SelectItemDto>> GetAllSelect()
        {
            return await _dbcontext.Furnizori.Select(x => new SelectItemDto { Value = x.Id, Label = x.Nume }).ToListAsync();
        }

        public async Task Update(Furnizor furnizor)
        {
            _dbcontext.Update(furnizor);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Delete(Furnizor furnizor)
        {
            _dbcontext.Remove(furnizor);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Create(Furnizor furnizor)
        {
            _dbcontext.Add(furnizor);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
