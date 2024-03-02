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
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/black screen.png"
            };
            
           return View(scene);
        }


       
        public ActionResult Prev()
        {
            return View();
        }   

        public ActionResult Next()
        {
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/black screen.png"
			};

			return View(scene);
		}

        public ActionResult Page1()
        {
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/black screen.png"
			};

			return View(scene);
		}

        public ActionResult Page2()
        {
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/black screen.png"
			};

			return View(scene);
		}
        public ActionResult Page3()
        {
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/black screen.png"
			};

			return View(scene);
		}
        public ActionResult Page4()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/Room-Scene.png"
            };

            return View(scene);
        }

        public ActionResult Page5()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/Room-Scene.png"
            };

            return View(scene);
        }

        public ActionResult Street()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/street-scene.png"
            };

            return View(scene);
        }
        public ActionResult Page6()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/street-scene.png"
            };

            return View(scene);
        }
        public ActionResult Page7()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/street-scene.png"
            };

            return View(scene);
        }
        public ActionResult Page8()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/street-scene.png"
            };

            return View(scene);
        }

        public ActionResult Page9()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/street-scene.png"
            };

            return View(scene);
        }

        public ActionResult Page11()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/street-scene.png"
            };

            return View(scene);
        }

        public ActionResult Page12()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/street-scene.png"
            };

            return View(scene);
        }


        public ActionResult Page13()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/street-scene.png"
            };

            return View(scene);
        }
        public ActionResult Page14()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/street-scene.png"
            };

            return View(scene);
        }

        public ActionResult Page15()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/black screen.png"
            };

            return View(scene);
        }

        public ActionResult Page16()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/black screen.png"
            };

            return View(scene);
        }

        public ActionResult Page17()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/black screen.png"
            };

            return View(scene);
        }

        public ActionResult Page18()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/black screen.png"
            };

            return View(scene);
        }

        public ActionResult Page19()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/black screen.png"
            };

            return View(scene);
        }

        public ActionResult Page20()
        {
            Scene scene = new Scene()
            {
                BackgroundImgURL = "~/images/Building-Scene.png"
            };

            return View(scene);
        }

		public ActionResult Page21()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/black screen.png"
			};

			return View(scene);
		}

		public ActionResult Page22()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/black screen.png"
			};

			return View(scene);
		}

		public ActionResult Page23()
        {
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/black screen.png"
			};

			return View(scene);
		}
        public ActionResult Page24()
        {
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};

			return View(scene);
		}
        public ActionResult Page25()
        {
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};

			return View(scene);
		}

		public ActionResult Page26()
		{
			return View();
		}

		public ActionResult Page27()
		{
			return View();
		}

		public ActionResult Page28()
		{
			return View();
		}

		public ActionResult Page29()
		{
			return View();
		}

		public ActionResult Page30()
		{
			return View();
		}

		public ActionResult Page31()
		{
			return View();
		}

		public ActionResult Page32()
		{
			return View();
		}

		public ActionResult Page33()
		{
			return View();
		}

		public ActionResult Page34()
		{
			return View();
		}

		public ActionResult Page35()
		{
			return View();
		}

		public ActionResult Page36()
		{
			return View();
		}

		public ActionResult Page37()
		{
			return View();
		}

		public ActionResult Page38()
		{
			return View();
		}

		public ActionResult Page39()
		{
			return View();
		}

		public ActionResult Page40()
		{
			return View();
		}

		public ActionResult Page41()
		{
			return View();
		}

		public ActionResult Page42()
		{
			return View();
		}

		public ActionResult Page43()
		{
			return View();
		}

		public ActionResult Page44()
		{
			return View();
		}

		public ActionResult Page45()
		{
			return View();
		}

		public ActionResult Page46()
		{
			return View();
		}

		public ActionResult Page47()
		{
			return View();
		}


		public ActionResult Page48()
		{
			return View();
		}


		public ActionResult Page49()
		{
			return View();
		}


		public ActionResult Page50()
		{
			return View();
		}

		public ActionResult Page51()
		{
			return View();
		}

		public ActionResult Page52()
		{
			return View();
		}

		public ActionResult Page53()
		{
			return View();
		}

		public ActionResult PageJu()
		{
			return View();
		}

	}

}
   



