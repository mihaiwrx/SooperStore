using Microsoft.EntityFrameworkCore;
using ProiectMDS.Contexts;
using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Services.ProdusService
{
    public class ProdusService: IProdusService
    {
        public Context _dbcontext { get; set; }

        public ProdusService(Context dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Produs> Get(int Id)
        {
            return await _dbcontext.Produse.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<Produs>> GetAll()
        {
            return await _dbcontext.Produse.Include(x=> x.Furnizor).Include(x=> x.Categorie).OrderBy(x=> x.Nume).ToListAsync();
        }

        public async Task Update(Produs produs)
        {
            _dbcontext.Update(produs);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Delete(Produs produs)
        {
            _dbcontext.Remove(produs);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Create(Produs produs)
        {
            _dbcontext.Add(produs);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
