using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        Product Insert(Product product);
        Product FindById(int id);
        Product Update(Product product);
        void RemoveById(int id);
        IReadOnlyList<Product> GetRandProducts(int takeCount);
    }
}