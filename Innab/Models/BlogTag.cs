using Microsoft.Extensions.Logging;

namespace Innab.Models
{
    public class BlogTag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
