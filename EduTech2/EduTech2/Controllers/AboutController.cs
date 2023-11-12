using EduTech2.DAL;
using EduTech2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EduTech2.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.AboutUs = _context.AboutUs.FirstOrDefault();
            homeVM.TrustedBies = _context.TrustedBies.ToList();
            return View(homeVM);
        }
    }
}
