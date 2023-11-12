using EduTech2.DAL;
using EduTech2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EduTech2.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Contact = _context.Contacts.FirstOrDefault();
            return View(homeVM);
            
        }
    }
}
