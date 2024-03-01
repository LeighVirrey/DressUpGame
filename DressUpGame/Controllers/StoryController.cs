using DressUpGame.Data;
using DressUpGame.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using static System.Formats.Asn1.AsnWriter;

namespace DressUpGame.Controllers
{
    public class StoryController : Controller
    {
        MongoDBDal DBDal = new MongoDBDal();
        public StoryController()
        {
        }
        
        //private List<Scene> storyScenes = new List<Scene>(); 

        //private int currentSceneIndex = 0; // Current index to keep track of the current scene

        public ActionResult StartGame()
        {
            
           return View();
        }


       
        public ActionResult Prev()
        {
            return View();
        }   

        public ActionResult Next()
        {
            return View();
        }

        public ActionResult Page1()
        {
            return View();
        }

        public ActionResult Page2()
        {
            return View();
        }
        public ActionResult Page3()
        {
            return View();
        }
        public ActionResult Page4()
        {
            return View();
        }

        public ActionResult Page5()
        {
            return View();
        }
        public ActionResult Page6()
        {
            return View();
        }
        public ActionResult Page7()
        {
            return View(); 
        }
        public ActionResult Page8()
        {
            return View();
        }

        public ActionResult Page9()
        {
            return View();
        }


 

        public ActionResult Page11()
        {
            return View();
        }

        public ActionResult Page12()
        {
            return View();
        }


        public ActionResult Page13()
        {
            return View();
        }
        public ActionResult Page14()
        {
            return View();
        }

        public ActionResult Page15()
        {
            return View();
        }

        public ActionResult Page16()
        {
            return View();
        }

        public ActionResult Page17()
        {
            return View();
        }

        public ActionResult Page18()
        {
            return View();
        }

        public ActionResult Page19()
        {
            return View();
        }

        public ActionResult Page20()
        {
            return View();
        }

		public ActionResult Page21()
		{
			return View();
		}

		public ActionResult Page22()
		{
			return View();
		}

		public ActionResult Page23()
        {
            return View();
        }
        public ActionResult Page24()
        {
            return View();
        }
        public ActionResult Page25()
        {
            return View();
        }





    }

}
   



