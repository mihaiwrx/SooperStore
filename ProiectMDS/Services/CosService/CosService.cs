using ProiectMDS.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;
using Microsoft.EntityFrameworkCore;

namespace ProiectMDS.Services.CosService
{
    public class CosService : ICosService
    {
        public Context _dbcontext { get; set; }

        public CosService(Context dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Cos> Get(int Id)
        {
            return await _dbcontext.Cos.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<Cos>> GetAll()
        {
            return await _dbcontext.Cos.ToListAsync();
        }

        public async Task Update(Cos cos)
        {
            _dbcontext.Update(cos);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Delete(Cos cos)
        {
            _dbcontext.Remove(cos);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Create(Cos cos)
        {
            _dbcontext.Add(cos);
            await _dbcontext.SaveChangesAsync();
        }
    }
}