using System.Web.Mvc;

namespace Catalog.Areas.CMS.Controllers
{
    public class HomeCmsController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }
    }
}