using Innab.DAL;
using Innab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Innab.ViewComponents
{
    public class CustomerDisplayViewComponent : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public CustomerDisplayViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Customers> customers = _appDbContext.Customers.ToList();

            return View(await Task.FromResult(customers));
        }
    }
}
