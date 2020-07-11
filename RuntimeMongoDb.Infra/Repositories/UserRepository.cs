using MongoDB.Driver;
using System.Threading.Tasks;
using System.Collections.Generic;
using RuntimeMongoDb.Domain.Entities;
using RuntimeMongoDb.Infra.Interfaces;
using MongoDB.Bson;

namespace RuntimeMongoDb.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoDbContext _mongoDbContext;

        public UserRepository(IMongoDbContext mongoDbContext)
        {
            _mongoDbContext = mongoDbContext;
        }

        private IMongoCollection<User> GetCollection() => _mongoDbContext.MongoDatabase.GetCollection<User>("users");

        public async Task<User> Create(User user)
        {
            await GetCollection().InsertOneAsync(user);
            return user;
        }

        public async Task<List<User>> GetAll()
        {
            var result = await GetCollection().Find(_ => true).ToListAsync();

            return result;
        }

        public async Task<User> GetById(int id)
        {
            var result = await GetCollection().FindAsync(f => f.Id == id);

            return result.FirstOrDefault();
        }
    }
}
