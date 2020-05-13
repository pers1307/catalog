using System.Web.Mvc;

namespace Catalog.Areas.CMS.Controllers
{
    public class ProductCmsController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}