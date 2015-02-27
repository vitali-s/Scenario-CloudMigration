using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CloudApplicationNet.Data.Content;

namespace CloudApplicationNet.Presentation.Controllers
{
    public class ContentItemsController : Controller
    {
        public const string ContentPath = "/content/";
        private readonly IContentRepository _contentRepository;

        public ContentItemsController(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        [HttpGet]
        public JsonResult Index()
        {
            var path = Server.MapPath(ContentPath);

            var items = _contentRepository
                .GetItems(path)
                .Select(item => new { name = item.Name, link = Uri.EscapeDataString(item.Name) });

            return Json(items, JsonRequestBehavior.AllowGet);
        }
    }
}