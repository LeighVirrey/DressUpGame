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


        //private List<Clothing> clothingList = DBdal.GetImages();
        public IActionResult GameOne()
		{

			ClothingListm();
			BsonDocument bsonElements = DBdal.getMia();
			Global.Mia.Image = bsonElements["Image"].ToString();
            var tuple = new Tuple<List<Clothing>, Character>(ClothingList, Global.Mia);
			ViewBag.Title = "GameOne";
			return View(tuple);
		}

		public IActionResult GameTwo()
		{
            ClothingListm();
            BsonDocument bsonElements = DBdal.getMia();
            Global.Mia.Image = bsonElements["Image"].ToString();
            var tuple = new Tuple<List<Clothing>, Character>(ClothingList, Global.Mia);
            ViewBag.Title = "GameOne";
            return View();
		}

		public IActionResult GameThree()
		{
            ClothingListm();
            BsonDocument bsonElements = DBdal.getMia();
            Global.Mia.Image = bsonElements["Image"].ToString();
            var tuple = new Tuple<List<Clothing>, Character>(ClothingList, Global.Mia);
            ViewBag.Title = "GameOne";
            return View();
		}
		public IActionResult Done()
		{
			return RedirectToAction(ViewBag.Next, "Story");
		}

		public IActionResult SelectClothing(string c, string view)
		{
            ClothingListm();
            Clothing clothing = ClothingList.Find(x => x.Name == c);
			if (clothing.type != null)
			{
				if (clothing.type == "HAT")
				{
					Global.Mia.Hat = clothing;
				}
				if (clothing.type == "HAIR")
				{
                    Global.Mia.Hair = clothing;
				}
				if (clothing.type == "SHIRT")
				{
                    Global.Mia.Shirt = clothing;
				}
				if (clothing.type == "PANTS")
				{
                    Global.Mia.Pants = clothing;
				}
				if (clothing.type == "SHOES")
				{
                    Global.Mia.Shoes = clothing;
				}

			}
            return Redirect(view);
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
			{
				Clothing c = new Clothing(typeClass[i], name[i], img[i]);

				ClothingList.Add(c);

			}

		}
	}
}



