using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace CodacyTestApp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}


		private void NewPrivateMethod()
		{
			// Deleted comment
			// test duplication
			List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
			StringBuilder sb = new StringBuilder();
			foreach (var item in list)
			{
				sb.Append(item);
			}
		}

		private void NewPrivateMethodMethod()
		{
			// Deleted comment
			// test duplication
			List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
			StringBuilder sb = new StringBuilder();
			foreach (var item in list)
			{
				sb.Append(item);
			}
		}
	}
}