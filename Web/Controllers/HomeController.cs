namespace Web.Controllers
{
	using MvcContrib;

	using System.Web.Mvc;

	public class HomeController : Controller
    {       
        public ActionResult StandardRedirectToAction()
        {
			return RedirectToAction("SomewhereElse");			
        }

		public ActionResult ContribRedirectToAction()
		{
			return this.RedirectToAction(x => x.SomewhereElse());
		}

		public ActionResult SomewhereElse()
		{
			return View();
		}
    }
}
