using Microsoft.AspNetCore.Mvc;

namespace Breshop.Controllers
{
    public class CarrinhoProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
