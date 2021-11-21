 
using softplayer.domain.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System.IO;

namespace softplayer.infra.data.Context
{
    public class MongoContext
    {
        private readonly MongoClient mongoClient;
        private readonly IMongoDatabase database;
        public IConfigurationRoot Configuration { get; }

        public MongoContext()
        {
            Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            mongoClient = new MongoClient(Configuration["MongoDB:ConnectionString"]);
            database = mongoClient.GetDatabase(Configuration["MongoDB:Database"]);
        }

        public IMongoCollection<Juros> Juros
        {
            get
            {
                return database.GetCollection<Juros>("Juros");
            }
        }
    }
}
