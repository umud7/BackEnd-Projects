﻿using EduTech2.DAL;
using EduTech2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EduTech2.ViewComponents
{

    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public HeaderViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio bio = _appDbContext.Bios.FirstOrDefault();

            return View(await Task.FromResult(bio));
        }


    }
}
