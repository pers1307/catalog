using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Catalog.Areas.CMS.Forms;
using Catalog.Entities;
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
        
        public ActionResult New()
        {
            IEnumerable<Article> articles = new List<Article>
            {
                new Article { Id = 0, Name = "Без категории" },
                new Article { Id = 1, Name = "Apple" },
                new Article { Id = 2, Name = "Samsung" },
                new Article { Id = 3, Name = "Google" }
            };
            ViewBag.articles = new SelectList(articles, "Id", "Name");
            
            return View(new ArticleForm());
        }
        
        [HttpPost]
        public ActionResult New(ArticleForm form)
        {
            if (ModelState.IsValid)
            {
                var r = 0;

                // Save
                /**
                * todo: тут редирект должен происходить уже на редактирование
                */
            } 
            
            IEnumerable<Article> articles = new List<Article>
            {
                new Article { Id = 0, Name = "Без категории" },
                new Article { Id = 1, Name = "Apple" },
                new Article { Id = 2, Name = "Samsung" },
                new Article { Id = 3, Name = "Google" }
            };
            ViewBag.articles = new SelectList(articles, "Id", "Name");
            
            return View(new ArticleForm());
        }
        
        public ActionResult Edit(int id)
        {
            return View();
        }
        
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}