using EduTech2.Models;
using System.Collections.Generic;

namespace EduTech2.ViewModels
{
    public class HomeVM
    {
        public Slider Slider { get; set; }
        public List<Feature> Features { get; set; }
        public FeatureSubject FeatureSubjects { get; set; }
        public List<OurPopularCourse> OurPopularCourses { get; set; }
        public OurPopularCourseSubject OurPopularCourseSubject { get; set; }
        public List<CountDown> CountDown { get; set; }
        public List<CommunityExperts> CommunityExperts { get; set; }
        public AboutUs AboutUs { get; set; }
        public List<TrustedBy> TrustedBies { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<BlogCategories> BlogCategories { get; set; }
        public List<Course> Course { get; set; }
        public Contact Contact { get; set; }
    }
}
