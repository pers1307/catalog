using System.Web.Mvc;
using Catalog.Areas.Catalog.Services;

namespace Catalog.Areas.Catalog.Controllers
{
    public class HomeController : Controller
    {        
        private IHomeViewModelService homeViewModelService;

        public HomeController(
            IHomeViewModelService homeViewModelService
        )
        {
            this.homeViewModelService = homeViewModelService;
        }

        public ActionResult Index()
        {
            /**
             * Сделать вывод категорий 
             */
            
            /**
             * Сделать вывод значений
             */
            
            /**
             * Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
             */
            
            // todo: доставать товары в рандомном порядке


            var homeViewModel = homeViewModelService.GetViewModel();
            
            return View(homeViewModel);
        }
    }
}