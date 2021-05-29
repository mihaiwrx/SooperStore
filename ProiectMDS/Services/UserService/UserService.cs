using ProiectMDS.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;
using Microsoft.EntityFrameworkCore;

namespace ProiectMDS.Services.UserService
{
    public class UserService : IUserService
    {
        public Context _dbcontext { get; set; }

        public UserService(Context dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<User> Get(int Id)
        {
            return await _dbcontext.Users.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<User>> GetAll()
        {
            return await _dbcontext.Users.ToListAsync();
        }

        public async Task Update(User user)
        {
            _dbcontext.Update(user);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Delete(User user)
        {
            _dbcontext.Remove(user);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Create(User user)
        {
            _dbcontext.Add(user);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
