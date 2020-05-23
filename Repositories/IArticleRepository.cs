using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public interface IArticleRepository
    {
        IEnumerable<Article> Articles { get; }
        IEnumerable<Article> GetForSelect();
        Article Insert(Article article);
        Article FindById(int id);
        Article Update(Article article);
        void RemoveById(int id);
    }
}