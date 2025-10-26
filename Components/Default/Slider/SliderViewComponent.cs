using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bilir.Components.Default
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public SliderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = await _context.Sliders.ToListAsync();
            return View(sliders);
        }
    }
}
