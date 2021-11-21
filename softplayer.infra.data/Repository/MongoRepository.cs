using MongoDbGenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace softplayer.infra.data.Repository
{
    public class MongoRepository : BaseMongoRepository, IMongoRepository
    {
        public MongoRepository(string connectionString, string databaseName) : base(connectionString, databaseName)
        {
        }

         public MongoRepository(IMongoDbContext mongoDbContext) : base(mongoDbContext)
        {
        }
        public void DropCollection<TDocument>()
        {
            MongoDbContext.DropCollection<TDocument>();
        }
         
        public void DropCollection<TDocument>(string partitionKey)
        {
            MongoDbContext.DropCollection<TDocument>(partitionKey);
        }
         
        public IMongoDbContext Context => MongoDbContext;
    }
}
