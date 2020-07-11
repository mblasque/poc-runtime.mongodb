using System.Threading.Tasks;
using System.Collections.Generic;
using RuntimeMongoDb.Domain.Entities;
using RuntimeMongoDb.Infra.Interfaces;
using RuntimeMongoDb.Services.Interfaces;

namespace RuntimeMongoDb.Services.Implementations
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Create(User user)
        {
            await _userRepository.Create(user);
        }

        public async Task<List<User>> GetAll()
        {
            return await _userRepository.GetAll();
        }

        public Task<User> GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
