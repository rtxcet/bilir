using Microsoft.AspNetCore.Mvc;

namespace bilir.Components.Default
{
    public class ContactMapViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
