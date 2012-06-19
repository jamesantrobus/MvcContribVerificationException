MvcContrib Debugging
====================

Replicating a System.Security.VerificationException in MvcContrib (RedirectToAction<T>)

There are two tests in Tests.HomeControllerFixture. One tests a standard RedirectToAction and passes. The other uses MvcContrib's RedirectToAction<T> which throws.
