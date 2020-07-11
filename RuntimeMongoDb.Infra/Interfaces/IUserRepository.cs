using System.Threading.Tasks;
using System.Collections.Generic;
using RuntimeMongoDb.Domain.Entities;

namespace RuntimeMongoDb.Infra.Interfaces
{
    public interface IUserRepository
    {
        Task Create(User user);

        Task<User> GetById(int id);

        Task<List<User>> GetAll();
    }
}
