using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;
using Catalog.Infrastructure.Concrete;

namespace Catalog.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private EFDbContext context = new EFDbContext();
        
        private Article zeroArticle = new Article()
        {
            Id = 0,
            Parent = 0,
            Name = "Нет родительской категории"
        }; 

        public IEnumerable<Article> Articles
        {
            get { return context.Articles; }
        }

        public IEnumerable<Article> GetForSelect()
        {
            var result = Articles.ToList();
            result.Insert(0, zeroArticle);
            
            return result;
        }

        public Article Insert(Article article)
        {
            context.Articles.Add(article);
            context.SaveChanges();
            
            return article; 
        }

        public Article FindById(int id)
        {
            return context
                .Articles
                .Find(id);
        }
        
        public Article Update(Article article)
        {
            var articleFormBase = FindById(article.Id);

            articleFormBase.Name        = article.Name;
            articleFormBase.Parent      = article.Parent;
            articleFormBase.Description = article.Description;

            context.SaveChanges();

            return articleFormBase;
        }

        public void RemoveById(int id)
        {
            var articleFormBase = FindById(id);
            
            context.Articles.Remove(articleFormBase);
            context.SaveChanges();
        }
    }
}