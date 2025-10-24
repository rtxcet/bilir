using Microsoft.AspNetCore.Mvc;

namespace bilir.Components.Shared.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
