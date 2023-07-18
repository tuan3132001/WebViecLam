using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebViecLam.Data;
using WebViecLam.Models;

namespace WebViecLam.Controllers
{
    public class HomeController : Controller
    {
		private readonly WebViecLamContext _context;

        public HomeController(WebViecLamContext context)
		{
			
			_context = context;
		}

		public IActionResult Index()
        {
			var _job = _context.Job.Include(j => j.Company);
			return View(_job.ToList());
        }

       
    }
}