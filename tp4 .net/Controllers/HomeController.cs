using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tp4_.net.Data;
using tp4_.net.Models;

namespace tp4_.net.Controllers
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
            UniversityContext u1 = UniversityContext.Instantiate_UniversityContext();
            List<Student> s = u1.Student.ToList();
            Debug.WriteLine(s);
            return View();
        }

        public IActionResult Privacy()
        {
            UniversityContext u2 = UniversityContext.Instantiate_UniversityContext();
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}