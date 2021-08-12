using MongoDB.Driver;

namespace GymRecords.DataLayer.Abstract
{
    public interface IMongoDbContext
    {
        IMongoCollection<TModel> GetCollection<TModel>(string dbName, string collectionName);
    }
}