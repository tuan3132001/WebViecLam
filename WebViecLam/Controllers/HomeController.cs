using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebViecLam.Models;

namespace WebViecLam.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
    }
}