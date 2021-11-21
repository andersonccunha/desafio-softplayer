using MongoDbGenericRepository;

namespace softplayer.infra.data.Repository
{
    public interface IMongoRepository : IBaseMongoRepository
    {    
        void DropCollection<TDocument>();
         void DropCollection<TDocument>(string partitionKey);
         
        IMongoDbContext Context { get; }
    }

}
