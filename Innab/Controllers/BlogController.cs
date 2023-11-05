using Innab.DAL;
using Innab.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Innab.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Blogs = _context.Blogs.ToList();
            return View(homeVM);
        }

        public IActionResult Detail(int id)
        {
            
            return View();

        }

    }
}
