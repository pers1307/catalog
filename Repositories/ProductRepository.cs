using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;
using Catalog.Infrastructure.Concrete;

namespace Catalog.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();
        
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
        
        
//        private Article zeroArticle = new Article()
//        {
//            Id = 0,
//            Parent = 0,
//            Name = "Нет родительской категории"
//        }; 

        

//        public IEnumerable<Article> GetForSelect()
//        {
//            var result = Articles.ToList();
//            result.Insert(0, zeroArticle);
//            
//            return result;
//        }

        public Product Insert(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            
            return product; 
        }

        public Product FindById(int id)
        {
            return context
                .Products
                .Find(id);
        }

        public IReadOnlyList<Product> GetRandProducts(int takeCount)
        {
            return context
                .Products
                .Take(takeCount)
                .ToList();
        }
        
        public Product Update(Product product)
        {
            var productFormBase = FindById(product.Id);

            productFormBase.Name        = product.Name;
            productFormBase.Description = product.Description;
            productFormBase.Price       = product.Price;    
            productFormBase.ImageOne    = product.ImageOne;
            productFormBase.ImageTwo    = product.ImageTwo;
            productFormBase.ImageThree  = product.ImageThree;

            context.SaveChanges();

            return productFormBase;
        }

        public void RemoveById(int id)
        {
            var productFormBase = FindById(id);
            
            context.Products.Remove(productFormBase);
            context.SaveChanges();
        }
    }
}