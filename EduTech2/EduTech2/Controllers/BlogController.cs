using EduTech2.DAL;
using EduTech2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EduTech2.Controllers
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
            homeVM.BlogCategories = _context.BlogCategories.ToList();
            return View(homeVM);
        }

        public IActionResult Detail(int id)
        {
            var course = _context.Blogs
            .Include(c => c.BlogDetails)
            .FirstOrDefault(c => c.Id == id);


            return View(course);
        }

    }
}
