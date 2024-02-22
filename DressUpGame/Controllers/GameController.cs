using Microsoft.AspNetCore.Mvc;

namespace DressUpGame.Controllers
{
	public class GameController : Controller
	{
		public IActionResult GameDiplay()
		{
			return View();
		}
	}
}
