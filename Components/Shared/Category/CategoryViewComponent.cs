using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bilir.Models;

namespace bilir.Components.Shared
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public CategoryViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Home bilgisi
            var home = await _context.Homes.FirstOrDefaultAsync();
            ViewBag.HomeTitle = home?.Title ?? "Bilir Teknoloji";

            // Kategoriler
            var categories = await _context.Categories.OrderBy(c => c.Id).ToListAsync();
            ViewBag.Categories = categories;

            return View();
        }
    }
}
