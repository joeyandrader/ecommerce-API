using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public static class UserQuery
    {
        public static string Create => """
                    INSERT INTO Users (FirstName, LastName, Email, Password, Cpf, Phone, Active)
                    VALUES (@FirstName, @LastName, @Email, @Password, @Cpf, @Phone, @Active);
                """;
    }
}
