using Innab.Models;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace Innab.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderContent SliderContent { get; set; }
        public List<Feature> Features { get; set; }
        public List<Counter> Counters { get; set; }
        public List<ServiceAndProject> ServiceAndProjects { get; set; }
        public List<Customers> Customers { get; set; }
        public About About { get; set; }
        public AboutPhoto AboutPhoto { get; set; }
        public List<Timeline> Timelines { get; set; }
        public Korporativ Korporativs { get; set; }
        public List<KorporativImage> KorporativImages { get; set; }
        public List<Category> Categories { get; set; }
        public List<Telim> Telims { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}


