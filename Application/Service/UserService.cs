using Domain.Entities;
using Domain.Repositories;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        public async Task<Users> Create(Users createDTO)
        {
           return await userRepository.Create(createDTO);
        }
    }
}
