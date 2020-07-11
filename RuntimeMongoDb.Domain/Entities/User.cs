using System;

namespace RuntimeMongoDb.Domain.Entities
{
    public class User
    {
        public User()
        {

        }

        public User(string name)
        {
            var rd = new Random();

            Id = rd.Next(9999);
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
