using MongoDB.Bson.Serialization;
using RuntimeMongoDb.Domain.Entities;

namespace RuntimeMongoDb.Infra.Mappings
{
    public static class MongoMap
    {
        public static void RegisterClasses()
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof(User)))
                BsonClassMap.RegisterClassMap<User>(
                      cm =>
                      {
                          cm.AutoMap();
                      });

        }
    }
}
