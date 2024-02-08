using Code_Challenge_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Code_Challenge_1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}


		List tm = new List();
		public IActionResult Index()
		{

            var model = new List<To-do-zList:>(); 

            model.Add("Manchester United");
            model.Add("Chelsea");
            model.Add("Manchester City");
            model.Add("Arsenal");
            model.Add("Liverpool");
            model.Add("Tottenham");

            return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}



		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

        public IActionResult List()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        }


    }
}