using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserAddress : BaseEntitie
    {
        public string? Address { get; set; }
        public string? District { get; set; }
        public string? Cep { get; set; }
        public string? Complement { get; set; }
        public string? City { get; set; }
        public string? Uf { get; set; }
        public int? Number { get; set; }
    }
}
