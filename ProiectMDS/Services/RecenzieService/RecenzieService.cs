using ProiectMDS.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;
using Microsoft.EntityFrameworkCore;

namespace ProiectMDS.Services.RecenzieService
{
    public class RecenzieService : IRecenzieService
    {
        public Context _dbcontext { get; set; }

        public RecenzieService(Context dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Recenzie> Get(int Id)
        {
            return await _dbcontext.Recenzii.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<Recenzie>> GetAll()
        {
            return await _dbcontext.Recenzii.Include(x=> x.Produs).ToListAsync();
        }

        public async Task<List<Recenzie>> GetAllByProductId(long id)
        {
            return await _dbcontext.Recenzii.Where(x=> x.ProdusId == id).Include(x => x.Produs).ToListAsync();
        }


        public async Task Update(Recenzie recenzie)
        {
            _dbcontext.Update(recenzie);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Delete(Recenzie recenzie)
        {
            _dbcontext.Remove(recenzie);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Create(Recenzie recenzie)
        {
            _dbcontext.Add(recenzie);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
