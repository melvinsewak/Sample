using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Sample.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SampleControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}