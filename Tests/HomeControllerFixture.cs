namespace Tests
{
	using NUnit.Framework;

	using Web.Controllers;

	[TestFixture]
	public class HomeControllerFixture
	{
		[Test]
		public void StandardRedirectToAction()
		{
			var controller = new HomeController();

			controller.StandardRedirectToAction();

			Assert.Pass();
		}

		[Test]
		public void ContribRedirectToAction()
		{
			var controller = new HomeController();

			controller.ContribRedirectToAction();

			Assert.Pass();
		}
	}
}
