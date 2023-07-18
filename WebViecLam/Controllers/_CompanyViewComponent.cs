using Microsoft.AspNetCore.Mvc;
using WebViecLam.Data;

namespace WebViecLam.Controllers
{
	[ViewComponent(Name= "_Company")]
	public class _CompanyViewComponent: ViewComponent
	{
		private readonly WebViecLamContext _context;

		public _CompanyViewComponent(WebViecLamContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			var _company = _context.Company.ToList();
			return View("_Company", _company);
		}
	}
}
