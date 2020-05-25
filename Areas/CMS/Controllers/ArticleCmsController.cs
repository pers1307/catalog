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
            SetArticlesForSelectInViewBag();
            return View("Edit", new ArticleForm());
        }
        
        [HttpPost]
        public ActionResult New(ArticleForm form)
        {
            if (ModelState.IsValid)
            {
                var saveArticle = repository.Insert(form.GetAsArticle());
                
                return RedirectToRoute(new
                {
                    action = "Edit",
                    id = saveArticle.Id.ToString()
                });
            } 
            
            SetArticlesForSelectInViewBag();
            return View("Edit", form);
        }
        
        public ActionResult Edit(int id)
        {
            var article = repository.FindById(id);

            if (article == null)
            {
                // todo: 404
            }

            SetArticlesForSelectInViewBag();
            return View(new ArticleForm(article));
        }
        
        [HttpPost]
        public ActionResult Edit(int id, ArticleForm form)
        {
            if (ModelState.IsValid)
            {
                var article = form.GetAsArticle();
                article.Id = id;
                repository.Update(article);
            }
            
            SetArticlesForSelectInViewBag();
            return View("Edit", form);
        }
        
        public ActionResult Delete(int id)
        {
            repository.RemoveById(id);
            
            return RedirectToRoute(new
            {
                controller = "ArticleCms",
                action = "Index"
            });
        }

        private void SetArticlesForSelectInViewBag()
        {
            ViewBag.articles = new SelectList(repository.GetForSelect(), "Id", "Name");
        }
    }
}