using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
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
		[HttpPost]
		public async Task<IActionResult> Search(string searchString)
		{
			if (searchString == null || _context.Job == null)
			{
				return NotFound();
			}

			var job = _context.Job.Include(j => j.Company).Where(j => j.JobName.Contains(searchString) || j.JobDescription.Contains(searchString)).ToList();
			return Json(job);
		}
		[HttpPost]
		public async Task<IActionResult> Filter(int filterString)
		{
			var jobf = _context.Job.Include(j => j.Company).Where(j => j.CompanyId.Equals(filterString)).ToList();
			return Json(jobf);
		}

	}
}