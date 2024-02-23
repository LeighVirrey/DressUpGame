using DressUpGame.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Formats.Asn1.AsnWriter;

namespace DressUpGame.Controllers
{
    public class StoryController : Controller
    {
        private List<Scene> storyScenes = new List<Scene>(); 

        private int currentSceneIndex = 0; // Current index to keep track of the current scene

        public ActionResult Index()
        {
            // Load your initial scene
            Scene currentScene = storyScenes[currentSceneIndex];
            return View(currentScene);
        }

        public ActionResult Next()
        {
            if (currentSceneIndex < storyScenes.Count - 1)
            {
                currentSceneIndex++;
            }

            Scene nextScene = storyScenes[currentSceneIndex];
            return View("Next", nextScene);
        }

        public ActionResult Prev()
        {
            if (currentSceneIndex > 0)
            {
                currentSceneIndex--;
            }

            Scene prevScene = storyScenes[currentSceneIndex];
            return View("Prev", prevScene);
        }
    }

}
    //{
    //    private List<Scene> scenes = new List<Scene>
    //{
    //    new Scene { Id = 1, Content = "This is scene 1." },
    //    new Scene { Id = 2, Content = "This is scene 2." },
    //    // Add more scenes as needed
    //};

    //    public ActionResult Index(int id = 1)
    //    {
    //        Scene scene = scenes.FirstOrDefault(s => s.Id == id);
    //        int totalScenes = scenes.Count;
    //        ViewBag.TotalScenes = totalScenes;
    //        return View(scene);
    //    }

    //    public ActionResult Next(int id)
    //    {
    //        Scene nextScene = scenes.FirstOrDefault(s => s.Id == id + 1);
    //        if (nextScene != null)
    //            return RedirectToAction("StartScene", new { id = nextScene.Id });
    //        else
    //            return RedirectToAction("Index", new { id });
    //    }

    //    public ActionResult Prev(int id)
    //    {
    //        Scene prevScene = scenes.FirstOrDefault(s => s.Id == id - 1);
    //        if (prevScene != null)
    //            return RedirectToAction("Index", new { id = prevScene.Id });
    //        else
    //            return RedirectToAction("Index", new { id });
    //    }


        
//}



