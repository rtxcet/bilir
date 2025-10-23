using Microsoft.AspNetCore.Mvc;

namespace bilir.Components.Default
{
    public class PopularViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
