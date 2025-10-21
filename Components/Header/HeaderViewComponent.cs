using Microsoft.AspNetCore.Mvc;

namespace bilir.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
