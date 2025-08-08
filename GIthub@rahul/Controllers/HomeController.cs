using GIthub_rahul.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GIthub_rahul.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // add
        public IActionResult Index()
        {
            return View();
        }
        // adding rahul
        public IActionResult Privacy()
        {
            return View();
        }
        // changes done by rahul for time pass
        //this changes made by rahul from git hub 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
