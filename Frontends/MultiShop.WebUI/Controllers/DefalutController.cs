using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.Controllers
{
    public class DefalutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
