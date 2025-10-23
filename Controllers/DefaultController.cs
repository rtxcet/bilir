using Microsoft.AspNetCore.Mvc;

namespace bilir.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
