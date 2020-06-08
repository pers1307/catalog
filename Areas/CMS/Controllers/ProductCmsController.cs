using System.Web.Mvc;
using Catalog.Areas.CMS.Forms;
using Catalog.Areas.CMS.Services;
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
                form = FileSaveService.SaveImagesFromProduct(form);
                var product = form.GetAsProduct();
                product.Id = id;
                              
                repository.Update(product);
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