using Innab.DAL;
using Innab.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Innab.Controllers
{
    public class KorporativController : Controller
    {
        private readonly AppDbContext _context;

        public KorporativController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Korporativs = _context.Korporativs.FirstOrDefault();
            homeVM.KorporativImages = _context.KorporativImages.ToList();

            return View(homeVM);
        }
    }
}
