using System.Web.Mvc;

namespace Catalog.Areas.CMS.Controllers
{
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }
    }
}