using System.Web.Mvc;

namespace Sample.Web.Controllers
{
    public class AboutController : SampleControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}