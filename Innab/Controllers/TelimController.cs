using Innab.DAL;
using Innab.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Innab.Controllers
{
    public class TelimController : Controller
    {
        private readonly AppDbContext _context;

        public TelimController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Telims = _context.Telims.ToList();
            homeVM.Categories = _context.Categories.ToList();

            return View(homeVM);
        }
    }
}
