using EduTech2.Models;
using Microsoft.EntityFrameworkCore;

namespace EduTech2.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatureSubject> FeatureSubjects { get; set; }
        public DbSet<OurPopularCourse> OurPopularCourses { get; set; }
        public DbSet<OurPopularCourseSubject> OurPopularCourseSubjects { get; set; }
        public DbSet<CountDown> CountDowns { get; set; }
        public DbSet<CommunityExperts> CommunityExperts { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<TrustedBy> TrustedBies { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategories> BlogCategories { get; set; }
        public DbSet<BlogDetails> BlogDetails { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
