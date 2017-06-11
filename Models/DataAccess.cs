using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace api_magicTheGathering.Models
{
    public class DataAccess
    {
        MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;
 
        public DataAccess()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _server = _client.GetServer();
            _db = _server.GetDatabase("magicTheGathering");      
        }
 
        public IEnumerable<Card> GetCards()
        {
            var sort = SortBy.Descending("cmc");
            return _db.GetCollection<Card>("cards").FindAll().SetSortOrder(sort);
        }
    }
}