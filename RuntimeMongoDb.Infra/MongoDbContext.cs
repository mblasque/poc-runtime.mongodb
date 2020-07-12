using Mongo2Go;
using MongoDB.Driver;
using RuntimeMongoDb.Infra.Mappings;
using RuntimeMongoDb.Domain.Entities;
using RuntimeMongoDb.Infra.Interfaces;

namespace RuntimeMongoDb.Infra
{
    public class MongoDbContext : IMongoDbContext
    {
        public IMongoClient MongoClient { get; }
        public IMongoDatabase MongoDatabase { get; }

        private readonly MongoDbRunner _mongoDbRunner;

        public MongoDbContext()
        {
            _mongoDbRunner = MongoDbRunner.Start();

            MongoClient = new MongoClient(_mongoDbRunner.ConnectionString);
            MongoDatabase = MongoClient.GetDatabase("db");

            MongoMap.RegisterClasses();

            var coll = MongoDatabase.GetCollection<User>("users");

            coll.InsertOne(new User("admin"));
        }
    }
}
