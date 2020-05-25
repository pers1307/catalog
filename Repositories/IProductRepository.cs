using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        Product Insert(Product product);
        Product FindById(int id);
    }
}