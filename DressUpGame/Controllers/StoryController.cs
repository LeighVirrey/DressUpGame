using Microsoft.AspNetCore.Mvc;

namespace DressUpGame.Controllers
{
	public class StoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
