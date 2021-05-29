using Microsoft.EntityFrameworkCore;
using ProiectMDS.Contexts;
using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Services.RolService
{
    public class RolService: IRolService
    {
        public Context _dbcontext { get; set; }

        public RolService(Context dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Rol> Get(int Id)
        {
            return await _dbcontext.Roluri.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<Rol>> GetAll()
        {
            return await _dbcontext.Roluri.ToListAsync();
        }

        public async Task Update(Rol rol)
        {
            _dbcontext.Update(rol);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Delete(Rol rol)
        {
            _dbcontext.Remove(rol);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Create(Rol rol)
        {
            _dbcontext.Add(rol);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
