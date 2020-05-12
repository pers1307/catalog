using System.Web.Mvc;

namespace Catalog.Areas.CMS.Controllers
{
    public class ArticleController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Edit()
        {
            return View();
        }
    }
}