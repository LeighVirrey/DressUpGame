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

		//List<Clothing> ClothingList = new List<Clothing>();

		private Character character;


		//private List<Clothing> clothingList = DBdal.GetImages();
		public IActionResult GameOne()
		{

			ClothingListm();
			BsonDocument bsonElements = DBdal.getMia();
			character = new Character(bsonElements["Image"].ToString(), bsonElements["Name"].ToString(), null, null, null, null, null);
            var tuple = new Tuple<List<Clothing>, Character>(ClothingList, character);
			return View(tuple);
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

		public IActionResult SelectClothing(Clothing c)
		{

			if (c.type != null)
			{
				if (c.type == "Hat")
				{
					character.Hat = c;
				}
				if (c.type == "Hair")
				{
					character.Hair = c;
				}
				if (c.type == "Shirt")
				{
					character.Shirt = c;
				}
				if (c.type == "Pants")
				{
					character.Pants = c;
				}
				if (c.type == "Shoes")
				{
					character.Shoes = c;
				}

			}

            return RedirectToAction("GameOne", "GameOne");
		}




		public void ClothingListm()
		{
			//List<BsonDocument> reeList = new List<BsonDocument>();
			//var ree = DBdal.GetImages().ConvertAll(BsonTypeMapper.MapToDotNetValue);
			List<BsonDocument> adConv = DBdal.GetImages();
			List<string> typeClass = new List<string>();
			List<string> img = new List<string>();
			List<string> name = new List<string>();


			foreach (BsonDocument bs in adConv)
			{
				if (bs["Type"].ToString() == "Hat" || bs["Type"].ToString() == "Hair" || bs["Type"].ToString() == "Shirt" || bs["Type"].ToString() == "Pants" || bs["Type"].ToString() == "Shoes")
				{
                    typeClass.Add(bs["Type"].ToString().ToUpper());
                    img.Add(bs["Image"].ToString());
                    name.Add(bs["Name"].ToString());
                }
            }
			
			for(int i = 0; i <= img.Count() - 1; i++)
>>>>>>> 08bba8ebd4a4fcfd26cafe05afade3723b7398e8
			{
				Clothing c = new Clothing(typeClass[i], name[i], img[i]);

				ClothingList.Add(c);

			}

		}
	}
}



