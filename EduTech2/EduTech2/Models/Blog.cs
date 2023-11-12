using System.Collections.Generic;

namespace EduTech2.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public BlogDetails BlogDetails { get; set; }
        public string BlogDetailsId { get; set; }
    }
}
