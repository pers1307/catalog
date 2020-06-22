using System.ComponentModel;
using Catalog.Areas.Catalog.ViewModels;
using Catalog.Repositories;

namespace Catalog.Areas.Catalog.Services
{
    public class HomeViewModelService : IHomeViewModelService
    {
        const int COUNT_PRODUCT_IN_MAIN = 6;
        
        private IArticleRepository articleRepository;
        private IProductRepository productRepository;

        public HomeViewModelService(
            IArticleRepository articleRepository,
            IProductRepository productRepository
        )
        {
            this.articleRepository = articleRepository;
            this.productRepository = productRepository;
        }
        
        public HomeViewModel GetViewModel()
        {
            var products = productRepository.GetRandProducts(COUNT_PRODUCT_IN_MAIN);
            
            /**
             * добвавить линки на продукты
             */
            
            /**
             * Добавить категории?
             */
            
            return new HomeViewModel(products);
        }
    }
}