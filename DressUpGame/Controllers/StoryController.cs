using DressUpGame.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Formats.Asn1.AsnWriter;

namespace DressUpGame.Controllers
{
    public class StoryController : Controller
    {


        
        //private List<Scene> storyScenes = new List<Scene>(); 

        //private int currentSceneIndex = 0; // Current index to keep track of the current scene

        public ActionResult StartGame()
        {
           return View();
        }


        public ActionResult Next()
        {
            return View("Page1");
        }

        public ActionResult Prev()
        {
            return View("StartGame");
        }
        public ActionResult Page2()
        {
            return View("Page3");
        }
        public ActionResult Page3()
        {
            return View("Page4");
        }
        public ActionResult Page5()
        {
            return View("Page6");
        }
        public ActionResult Page6()
        {
            return View("Page7");
        }
        public ActionResult Page7()
        {
            return View("Page8");
        }
        public ActionResult Page8()
        {
            return View("Page9");
        }




    }

}
   



