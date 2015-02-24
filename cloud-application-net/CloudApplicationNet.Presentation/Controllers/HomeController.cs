using System.Web.Mvc;

namespace CloudApplicationNet.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Layout.cshtml");
        }
    }
}