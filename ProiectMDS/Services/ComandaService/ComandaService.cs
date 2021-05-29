using Microsoft.EntityFrameworkCore;
using ProiectMDS.Contexts;
using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Services.ComandaService
{
    public class ComandaService:IComandaService
    {
        public Context _dbcontext { get; set; }

        public ComandaService(Context dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Comanda> Get(int Id)
        {
            return await _dbcontext.Comenzi.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<Comanda>> GetAll()
        {
            return await _dbcontext.Comenzi.ToListAsync();
        }

        public async Task Update(Comanda comanda)
        {
            _dbcontext.Update(comanda);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Delete(Comanda comanda)
        {
            _dbcontext.Remove(comanda);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Create(Comanda comanda)
        {
            _dbcontext.Add(comanda);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
