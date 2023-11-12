using EduTech2.DAL;
using EduTech2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduTech2.ViewComponents
{
    public class CourseViewComponent : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public CourseViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Course> courses = _appDbContext.Courses.ToList();

            return View(await Task.FromResult(courses));
        }

    }
}
