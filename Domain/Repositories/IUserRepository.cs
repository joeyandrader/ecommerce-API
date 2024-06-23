using Domain.Entities;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
        Task<Users> Create(Users createDTO);
        Task<Users> Update(int id, Users updateDTO);
        Task<Users> Get(int id);
        Task<List<Users>> List();
        Task<bool> Delete(int id);
    }
}
