using EduTech2.DAL;
using EduTech2.Models;
using EduTech2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EduTech2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           HomeVM homeVM = new HomeVM();
            homeVM.Slider = _context.Sliders.FirstOrDefault();
            homeVM.Features = _context.Features.ToList();
            homeVM.FeatureSubjects = _context.FeatureSubjects.FirstOrDefault();
            homeVM.OurPopularCourses = _context.OurPopularCourses.ToList();
            homeVM.OurPopularCourseSubject = _context.OurPopularCourseSubjects.FirstOrDefault();
            homeVM.CountDown = _context.CountDowns.ToList();
            homeVM.CommunityExperts = _context.CommunityExperts.ToList();
            return View(homeVM);
        }
    }
}
