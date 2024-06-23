using Dapper;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Querys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository(IDbConnection connection) : IUserRepository
    {
        public async Task<Users> Create(Users createDTO)
        {
            try
            {
                var result = await connection.ExecuteAsync(UserQuery.Create, new
                {
                    FirstName = createDTO.FirstName,
                    LastName = createDTO.LastName,
                    Email = createDTO.Email,
                    Password = createDTO.Password,
                    Cpf = createDTO.Cpf,
                    Phone = createDTO.Phone,
                    Active = createDTO.Active,
                });
                if (result == 0)
                    throw new Exception("Erro ao criar usuario");
                return createDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
