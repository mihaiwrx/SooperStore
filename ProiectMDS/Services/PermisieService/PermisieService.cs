using ProiectMDS.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;
using Microsoft.EntityFrameworkCore;

namespace ProiectMDS.Services.PermisieService
{
    public class PermisieService : IPermisieService
    {
        public Context _dbcontext { get; set; }

        public PermisieService(Context dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Permisie> Get(int Id)
        {
            return await _dbcontext.Permisii.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<Permisie>> GetAll()
        {
            return await _dbcontext.Permisii.ToListAsync();
        }

        public async Task Update(Permisie permisie)
        {
            _dbcontext.Update(permisie);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Delete(Permisie permisie)
        {
            _dbcontext.Remove(permisie);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Create(Permisie permisie)
        {
            _dbcontext.Add(permisie);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
