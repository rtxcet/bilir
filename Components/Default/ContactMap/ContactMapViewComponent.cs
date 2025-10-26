using bilir.Models;
using Microsoft.AspNetCore.Mvc;

namespace bilir.Components.Default
{
    public class ContactMapViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new Contact(); // Boş form modeli
            return View(model);        // Form sayfasına bu modeli gönderiyoruz
        }
    }
}
