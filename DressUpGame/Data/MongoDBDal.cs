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
        public void AddImage(string Image, string name, string type)
        {
            Setup();
            if(type == null && name == null)
            {
                BsonDocument doc = new BsonDocument
            {
                {"Image", Image}
            };
                DBcollection.InsertOne(doc);
            }
            else
            {
                BsonDocument doc = new BsonDocument
            {
                {"Image", Image},
                {"Name", name},
                {"Type", type}
            };
                DBcollection.InsertOne(doc);
            }
        }
        public List<BsonDocument> getImagesType(string clothing)
        {
            Setup();
            var filter = Builders<BsonDocument>.Filter.Eq("Type", clothing);
            return DBcollection.Find(filter).ToList();
        }
        public List<BsonDocument> GetScenes()
        {
            Setup();
            return DBcollection.Find(Builders<BsonDocument>.Filter.Empty).ToList();
        }
        public BsonDocument GetScene(string name)
        {
            Setup();
            var filter = Builders<BsonDocument>.Filter.Eq("Name", name);
            return DBcollection.Find(filter).FirstOrDefault();
        }
        public List<BsonDocument> getAds()
        {
            Setup();
            var filter = Builders<BsonDocument>.Filter.Eq("Type", "Ad");
            return DBcollection.Find(filter).ToList();
        }
        public BsonDocument getMia()
        {
            Setup();
            var filter = Builders<BsonDocument>.Filter.Eq("Name", "Mia");
            return DBcollection.Find(filter).FirstOrDefault();
        }
        public void Setup()
        {
            IMongoClient mongoClient = new MongoClient("mongodb+srv://lvirrey:Nc210859027@toonzk.0byxsso.mongodb.net/");
            var database = mongoClient.GetDatabase("DressUpDollDB");
            DBcollection = database.GetCollection<BsonDocument>("Images");
        }
    }
}
