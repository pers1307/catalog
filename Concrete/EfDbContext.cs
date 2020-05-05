using System.Data.Entity;
using Catalog.Entities;

namespace Catalog.Concrete
{
    public class EfDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}