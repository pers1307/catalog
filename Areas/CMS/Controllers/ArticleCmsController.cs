using System.Linq;
using System.Web.Mvc;
using Catalog.Repositories;

namespace Catalog.Areas.CMS.Controllers
{
    public class ArticleCmsController : Controller
    {
        private IArticleRepository repository;

        public ArticleCmsController(IArticleRepository articleRepository)
        {
            repository = articleRepository;
        }
        
        public ActionResult Index()
        {
            return View(repository.Articles);
        }
        
        public ActionResult Edit()
        {
            return View();
        }
    }
}