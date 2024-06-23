using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IUserService
    {
        Task<Users> Create(Users createDTO);
        Task<Users> Update(int id, Users updateDTO);
        Task<Users> Get(int id);
        Task<List<Users>> List();
        Task<bool> Delete(int id);
    }
}
