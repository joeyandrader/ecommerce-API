using Domain.Entities;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Facade
{
    public class UserFacade(IUserService userService)
    {

        public async Task<Users> Create(Users createDTO)
        {
            return await userService.Create(createDTO);
        }
    }
}
