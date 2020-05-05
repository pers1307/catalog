namespace Catalog.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Parent { get; set; }
        public string Description { get; set; }
    }
}