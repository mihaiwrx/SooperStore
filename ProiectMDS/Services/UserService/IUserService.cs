using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Services.UserService
{
    public interface IUserService
    {
        Task<User> Get(int Id);
        Task<List<User>> GetAll();

        Task Update(User user);

        Task Delete(User user);

        Task Create(User user);
    }
}
