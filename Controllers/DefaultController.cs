using bilir.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bilir.Controllers
{
    public class DefaultController : Controller
    {
        private readonly AppDbContext _context;

        public DefaultController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("kategori/{id}")]
        public IActionResult ProductsByCategory(string slug, int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
                return NotFound();

            var products = _context.Products
                .Where(p => p.CategoryId == id)
                .Include(p => p.Category)
                .ToList();

            ViewBag.CategoryName = category.Title;

            return View(products);
        }


        public async Task<IActionResult> Detail(int id)
        {
            // Product ve Category bilgisini asenkron çekiyoruz
            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);

            // Home bilgisi
            var home = await _context.Homes.FirstOrDefaultAsync();
            ViewBag.Phone = home?.WhattsapPhone;

            // Product bulunamadıysa 404
            if (product == null)
                return NotFound();

            return View(product);
        }


        [HttpGet("/products/search")]
        public async Task<IActionResult> Search(string q)
        {
            if (string.IsNullOrWhiteSpace(q))
                return View("SearchResults", new List<Product>());

            var results = await _context.Products
                .Where(p => p.Name.Contains(q) || p.Description.Contains(q))
                .ToListAsync();

            return View(results);
        }
    }
}
