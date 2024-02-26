using DressUpGame.Data;
using DressUpGame.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System.Diagnostics;
using System.Text.Json;

namespace DressUpGame.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        MongoDBDal DBdal = new MongoDBDal();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Game()
        {
            return View();
        }


        public IActionResult Test()
        {
            //List<Json> data = DBdal.GetImages().ToJson();
            List<BsonDocument> BsonList = DBdal.GetImages();
            var ObjList = BsonList.ConvertAll(BsonTypeMapper.MapToDotNetValue);
            ViewBag.Data = ObjList;
            return View();
        }
        public IActionResult Add(IFormFile Image)
        {
            if (Image != null)
            {
                MemoryStream ms = new MemoryStream();
                Image.CopyTo(ms);
                string ImageBytes = Convert.ToBase64String(ms.ToArray());
                ms.Close();
                DBdal.AddImage(ImageBytes);
            }
            return RedirectToAction("Test");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
