using Microsoft.AspNetCore.Mvc;

namespace bilir.Components.Shared.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
