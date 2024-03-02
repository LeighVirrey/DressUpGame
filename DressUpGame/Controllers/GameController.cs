using DressUpGame.Data;
using DressUpGame.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace DressUpGame.Controllers
{
	public class GameController : Controller
	{
		MongoDBDal DBdal = new MongoDBDal();
        List<Clothing> ClothingList = new List<Clothing>();


        //private List<Clothing> clothingList = DBdal.GetImages();
        public IActionResult GameOne()
		{

			ClothingListm();
			return View();
		}

		public IActionResult GameTwo()
		{
            ClothingListm();
            return View();
		}

		public IActionResult GameThree()
		{
            ClothingListm();
            return View();
		}


		public void ClothingListm()
		{
			//List<BsonDocument> reeList = new List<BsonDocument>();
			//var ree = DBdal.GetImages().ConvertAll(BsonTypeMapper.MapToDotNetValue);
			List<BsonDocument> adConv = DBdal.GetImages();
			List<string> typeClass = new List<string>();
			List<string> img = new List<string>();
			List<string> name = new List<string>();
			//foreach (var type in Enum.GetNames<Clothing.Type>())
			//{
			//	List<BsonDocument> adConv = DBdal.getImagesType(type);
			//	foreach (BsonDocument bs in adConv)
			//	{
			//		img.Add(bs["Type"].ToString());
			//	}
			//	foreach (BsonDocument bs in adConv)
			//	{
			//		img.Add(bs["Image"].ToString());
			//	}

			//	foreach (BsonDocument bs in adConv)
			//	{
			//		name.Add(bs["Name"].ToString());
			//	}
			//}
			//
			//This would have probably worked but it called on the database too many times and was not efficient, rewritten to what's down below. Marcus had the right idea -ZK



			foreach (BsonDocument bs in adConv)
			{
				if (bs["Type"].ToString() == "Hat" || bs["Type"].ToString() == "Hair" || bs["Type"].ToString() == "Shirt" || bs["Type"].ToString() == "Pants" || bs["Type"].ToString() == "Shoes")
				{
                    typeClass.Add(bs["Type"].ToString());
                    img.Add(bs["Image"].ToString());
                    name.Add(bs["Name"].ToString());
                }
            }
			
			for(int i = 0; i <= img.Count() - 1; i++)
			{
				Clothing c = new Clothing(typeClass[i], name[i], img[i]);

				ClothingList.Add(c);

			}
		}
	}
}
