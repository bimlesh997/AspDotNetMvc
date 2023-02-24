using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace test2.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : test2ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}