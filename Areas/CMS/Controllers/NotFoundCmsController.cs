using System.Web.Mvc;

namespace Catalog.Areas.CMS.Controllers
{
    public class NotFoundCmsController : Controller
    {
        public ActionResult NotFound()
        {
            ViewBag.referrer = Request.UrlReferrer?.ToString();
            Response.StatusCode = 404;
            return View();
        }
    }
}