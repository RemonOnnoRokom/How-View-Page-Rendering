using System.Diagnostics;
using System.Text.Encodings.Web;
using Learn.AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Learn.AspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //specified that the method should use a view template file to render a response to the browser.
            // if view template file name wasn't specified so MVC defaulted to using the default view file as the Action method name
            return View();
        }

        public string Welcome(string name, int numTimes = 1)
        {
            return $"{name} is a honest boy";
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
    }
}
