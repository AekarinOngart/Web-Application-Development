using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using project.MyClass;
using System.Data;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        private ConDB ConDB = new ConDB();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if(chkLogin() == true)
            {
                return View();
            }
            else
            {
                return View("Login");
            }
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

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username,string password)
        {
            DataTable dt = ConDB.GetData($"SELECT * FROM `user` WHERE username = '{username}';");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["password"].ToString() == EncodeString.MD5HashCryptography(password))
                {
                    HttpContext.Session.SetString("Login", "1");
                    return View("Index");
                }
            }
            return View();
        }
        private bool chkLogin()
        {
            bool result = false;
            if(HttpContext.Session.GetString("Login") != null)
            {
                if(HttpContext.Session.GetString("Login") == "1")
                {
                    result = true;
                }
            }
            return result;
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
    }
}
