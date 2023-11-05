using Innab.DAL;
using Innab.Models;
using Innab.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Innab.Controllers
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
            homeVM.Sliders = _context.Sliders.ToList();
            homeVM.SliderContent = _context.SliderContents.FirstOrDefault();
            homeVM.Features = _context.Features.ToList();
            homeVM.Counters = _context.Counters.ToList();
            homeVM.ServiceAndProjects = _context.ServiceAndProjects.ToList();
            homeVM.Customers = _context.Customers.ToList();

            return View(homeVM);
        }
    }
}
