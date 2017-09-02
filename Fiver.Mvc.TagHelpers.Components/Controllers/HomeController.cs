using Microsoft.AspNetCore.Mvc;

namespace Fiver.Mvc.TagHelpers.Components.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
