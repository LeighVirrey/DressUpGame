using DressUpGame.Data;
using DressUpGame.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace DressUpGame.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        MongoDBDal DBDal = new MongoDBDal();

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
            List<BsonDocument> adConv = DBDal.getAds();
            List<string> ads = new List<string>();
            foreach (BsonDocument ad in adConv)
            {
                ads.Add(ad["Image"].ToString());
            }
            ViewBag.Ads = ads;
            return View();
        }

        [Route("debug")]
        [Route("home/test")]
        public IActionResult Test()
        {
            //List<Json> data = DBdal.GetImages().ToJson();
            List<BsonDocument> BsonList = DBDal.GetImages();
            var ObjList = BsonList.ConvertAll(BsonTypeMapper.MapToDotNetValue);
            ViewBag.Data = ObjList;
            return View();
        }
        public IActionResult Add(IFormFile Image, string? type, string? name)
        {
            if (Image != null)
            {
                MemoryStream ms = new MemoryStream();
                Image.CopyTo(ms);
                string ImageBytes = Convert.ToBase64String(ms.ToArray());
                ms.Close();
                DBDal.AddImage(ImageBytes, name, type);
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
