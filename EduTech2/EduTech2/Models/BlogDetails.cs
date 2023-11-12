using System.Collections.Generic;

namespace EduTech2.Models
{
    public class BlogDetails
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
