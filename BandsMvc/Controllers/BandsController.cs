using Microsoft.AspNetCore.Mvc;

namespace BandsMvc.Controllers
{
    public class BandsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
