using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.Json;

namespace DressUpGame.Data
{
    public class MongoDBDal
    {
        private static IMongoCollection<BsonDocument> DBcollection;
        public List<BsonDocument> GetImages()
        {
            Setup();
            return DBcollection.Find(Builders<BsonDocument>.Filter.Empty).ToList();
        }
        public void AddImage(string Image)
        {
            Setup();
            BsonDocument doc = new BsonDocument
            {
                {"Image", Image}
            };
            DBcollection.InsertOne(doc);
        }
        public void Setup()
        {
            IMongoClient mongoClient = new MongoClient("mongodb+srv://lvirrey:Nc210859027@toonzk.0byxsso.mongodb.net/");
            var database = mongoClient.GetDatabase("DressUpDollDB");
            DBcollection = database.GetCollection<BsonDocument>("Images");
        }
    }
}
