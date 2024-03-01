using DressUpGame.Data;
using DressUpGame.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace DressUpGame.Controllers
{
	public class GameController : Controller
	{
		MongoDBDal DBdal = new MongoDBDal();
		List<Clothing> ClothingList;
       

        //private List<Clothing> clothingList = DBdal.GetImages();
        public IActionResult GameDiplay()
		{
			return View();
		}

		public IActionResult ClothingListm()
		{
			List<BsonDocument> reeList = new List<BsonDocument>();
			var ree = DBdal.GetImages().ConvertAll(BsonTypeMapper.MapToDotNetValue);

			List<BsonDocument> adConv = DBdal.GetImages();
			List<string> img = new List<string>();
			List<string> name = new List<string>();
			
			foreach(BsonDocument bs in adConv)
			{
				img.Add(bs["Image"].ToString());
			}

			foreach(BsonDocument bs in adConv)
			{
				name.Add(bs["Name"].ToString());
			}
			
			for(int i = 0; i <= img.Count(); i++)
			{
				Clothing c = new Clothing("dsaf", name[i], img[i]);

				ClothingList.Add(c);

			}

			return View();
		}
	}
}
