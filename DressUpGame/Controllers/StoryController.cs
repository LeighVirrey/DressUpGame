﻿using DressUpGame.Data;
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
			Global.nextView = "Page24";
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
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page27()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page28()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page29()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page30()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page31()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page32()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page33()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page34()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page35()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			Global.nextView = "Page36";
            return View(scene);
		}

		public ActionResult Page36()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page37()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page37half()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page38()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page39()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page40()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page41()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page42()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page43()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page44()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page45()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page46()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page47()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			Global.nextView = "Page48";
            return View(scene);
		}


		public ActionResult Page48()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}


		public ActionResult Page49()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}


		public ActionResult Page50()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page51()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult Page52()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};

			return View(scene);
		}

		public ActionResult Page53()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

		public ActionResult PageJu()
		{
			Scene scene = new Scene()
			{
				BackgroundImgURL = "~/images/waiting-room-scene.png"
			};
			return View(scene);
		}

	}

}
   



