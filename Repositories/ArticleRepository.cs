using System.Collections.Generic;
using Catalog.Entities;
using Catalog.Infrastructure.Concrete;

namespace Catalog.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Article> Articles
        {
            get { return context.Articles;  }
        }
    }
}