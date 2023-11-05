using Microsoft.Extensions.Logging;

namespace Innab.Models
{
    public class BlogDetails
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Date { get; set; }
        public Blog Blog { get; set; }
        public int BlogId { get; set; }
        public BlogTag BlogTag { get; set; }
    }
}
