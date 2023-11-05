using Innab.DAL;
using Innab.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Innab.Controllers
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
            homeVM.About = _context.Abouts.FirstOrDefault();
            homeVM.AboutPhoto = _context.AboutPhotos.FirstOrDefault();
            homeVM.Timelines = _context.Timelines.ToList();

            return View(homeVM);
        }
    }
}
