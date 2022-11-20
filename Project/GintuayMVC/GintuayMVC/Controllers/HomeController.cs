using Gintuay.Data;
using GintuayMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GintuayMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Queueorder()
        {
            return View();
        }
        public IActionResult Queuebuyorder()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult main()
        {
            Console.WriteLine("Test");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Addorder()
        {
            return View();
        }
        public IActionResult Editprofile()
        {
            return View();
        }
        public IActionResult Create_order()
        {
            return View();
        }
        public IActionResult Postmenu()
        {
            return View();
        }

        public IActionResult Popup()
        {
            return View();
        }



        private readonly ApiContext _context;
        public JsonResult Get(int id)
        {
            var result = _context.Users.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}