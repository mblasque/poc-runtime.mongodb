using MongoDB.Driver;

namespace RuntimeMongoDb.Infra.Interfaces
{
    public interface IMongoDbContext
    {
        public IMongoClient MongoClient { get; }
        public IMongoDatabase MongoDatabase { get; }
    }
}
