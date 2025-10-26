using bilir.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bilir.Components.Default
{
    public class ServiceViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public ServiceViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Home bilgisi
            var home = await _context.Homes.FirstOrDefaultAsync();
            ViewBag.Phone = home?.Phone ;
            ViewBag.WhattsapPhone = home?.WhattsapPhone ;

            // Kategoriler
            var service = await _context.Services.FirstOrDefaultAsync();

            return View(service);
        }
    }
}
