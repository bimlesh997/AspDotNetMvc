using System.Web.Mvc;

namespace test2.Web.Controllers
{
    public class AboutController : test2ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}