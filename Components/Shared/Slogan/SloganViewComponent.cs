using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bilir.Components.Shared.Footer
{
    public class SloganViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public SloganViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var siteSettings = await _context.Slogans.ToListAsync();
            return View(siteSettings);
        }
    }
}
