using System.Threading.Tasks;
using System.Collections.Generic;
using RuntimeMongoDb.Domain.Entities;

namespace RuntimeMongoDb.Services.Interfaces
{
    public interface IUserServices
    {
        Task Create(User user);

        Task<User> GetById(int id);

        Task<List<User>> GetAll();
    }
}
