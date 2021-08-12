using System;
using GymRecords.DataLayer.Abstract;
using MongoDB.Driver;

namespace GymRecords.DataLayer.Services
{
    public class MongoDbContext: IMongoDbContext
    {
        private IMongoDatabase ConnectToDatabase(string dbName)
        {
            var login = Environment.GetEnvironmentVariable("DB_LOGIN");
            var password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            var client = new MongoClient(
                $"mongodb+srv://{login}:{password}@Helper-dlcu6.azure.mongodb.net/test?retryWrites=true&w=majority");
            var database = client.GetDatabase(dbName);
            return database;
        }
        
        public IMongoCollection<TModel> GetCollection<TModel>(string dbName, string collectionName)
        {
            return ConnectToDatabase(dbName).GetCollection<TModel>(collectionName);
        }
    }
}