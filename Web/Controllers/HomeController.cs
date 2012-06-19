namespace Web.Controllers
{
	using MvcContrib;

	using System.Web.Mvc;

	public class HomeController : Controller
    {       
        public ActionResult Index()
        {
			return this.RedirectToAction(x => x.SomewhereElse());
        }

		public ActionResult SomewhereElse()
		{
			return View();
		}
    }
}
