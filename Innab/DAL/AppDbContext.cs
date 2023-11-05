using Innab.Models;
using Microsoft.EntityFrameworkCore;

namespace Innab.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderContent> SliderContents { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<ServiceAndProject> ServiceAndProjects { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutPhoto> AboutPhotos { get; set; }
        public DbSet<Timeline> Timelines { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Korporativ> Korporativs { get; set; }
        public DbSet<KorporativImage> KorporativImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Telim> Telims { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetails> BlogDetails { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }



    }
}
