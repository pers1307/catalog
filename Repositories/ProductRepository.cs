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
        
//        public Article Update(Article article)
//        {
//            var articleFormBase = FindById(article.Id);
//
//            articleFormBase.Name        = article.Name;
//            articleFormBase.Parent      = article.Parent;
//            articleFormBase.Description = article.Description;
//
//            context.SaveChanges();
//
//            return articleFormBase;
//        }
//
//        public void RemoveById(int id)
//        {
//            var articleFormBase = FindById(id);
//            
//            context.Articles.Remove(articleFormBase);
//            context.SaveChanges();
//        }
    }
}