using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public interface IArticleRepository
    {
        IEnumerable<Article> Articles { get; }
    }
}