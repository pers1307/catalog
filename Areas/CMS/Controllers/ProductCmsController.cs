using System.Web.Mvc;
using Catalog.Areas.CMS.Forms;
using Catalog.Repositories;

namespace Catalog.Areas.CMS.Controllers
{
    public class ProductCmsController : Controller
    {
        private IProductRepository repository;

        public ProductCmsController(IProductRepository productRepository)
        {
            repository = productRepository;
        }
        
        public ActionResult Index()
        {
            return View(repository.Products);
        }
        
        public ActionResult New()
        {            
            return View("Edit", new ProductForm());
        }
        
        [HttpPost]
        public ActionResult New(ProductForm form)
        {
            if (ModelState.IsValid)
            {
                var saveArticle = repository.Insert(form.GetAsProduct());

                return RedirectToRoute(new
                {
                    controller="ProductCms",
                    action = "Edit",
                    id = saveArticle.Id.ToString()
                });
            } 

            return View("Edit", form);
        }
        
        public ActionResult Edit(int id)
        {
            var product = repository.FindById(id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(new ProductForm(product));
        }
        
        [HttpPost]
        public ActionResult Edit(int id, ProductForm form)
        {
            if (ModelState.IsValid)
            {
                var article = form.GetAsProduct();
                article.Id = id;

                var t = form.ImageOne.FileName;
                
                string fileName = System.IO.Path.GetFileName(t);
                // сохраняем файл в папку Files в проекте
//                upload.SaveAs(Server.MapPath("~/Files/" + fileName));

                form.ImageOne.SaveAs(Server.MapPath("~/Files/" + fileName));
                
                repository.Update(article);
            }
            
            return View("Edit", form);
        }
        
        public ActionResult Delete(int id)
        {
            repository.RemoveById(id);
            
            return RedirectToRoute(new
            {
                controller = "ProductCms",
                action = "Index"
            });
        }
    }
}