using System.Data.Entity;
using Catalog.Entities;

namespace Catalog.Infrastructure.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}