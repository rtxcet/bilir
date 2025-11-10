using bilir.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bilir.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var service = await _context.Services.FirstOrDefaultAsync();

            if (service == null)
            {
                service = new Service
                {
                    Title = "",
                    Description = "",
                };

                _context.Services.Add(service);
                await _context.SaveChangesAsync();
            }

            ViewBag.Message = TempData["SuccessMessage"];
            return View(service);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Service model)
        {
            var service = await _context.Services.FirstOrDefaultAsync();
            if (service == null)
                return NotFound();

            // Metin alanlarını güncelle
            service.Title = model.Title;
            service.Description = model.Description;
           
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "Başarıyla güncellendi.";

            return RedirectToAction("Index");
        }
    }
}
