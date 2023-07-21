using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebViecLam.Data;

namespace WebViecLam.Controllers
{
	[ViewComponent(Name = "_CompanySide")]
	public class _CompanySideViewComponent: ViewComponent
	{
		private readonly WebViecLamContext _context;
		
		public  _CompanySideViewComponent(WebViecLamContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			var _company = _context.Company.ToList();
			return View("_CompanySide", _company);
		}
	}
}
