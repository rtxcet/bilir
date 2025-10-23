using Microsoft.AspNetCore.Mvc;

namespace bilir.Components.Default
{
    public class LatestAddViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
