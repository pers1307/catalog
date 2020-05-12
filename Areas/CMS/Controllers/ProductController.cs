using System.Web.Mvc;

namespace Catalog.Areas.CMS.Controllers
{
    public class ProductController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}