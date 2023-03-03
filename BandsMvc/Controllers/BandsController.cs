using BandsMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandsMvc.Controllers
{
    public class BandsController : Controller
    {
        DataService dataService = new DataService();
        [HttpGet("")]
        [HttpGet("bands/index")]
      
        public IActionResult Index()
        {
            Band[] model = dataService.GetAll();
            return View(model);
        }

        [HttpGet("bands/details/{id}")]
        public IActionResult Details(int id) 
        {
            Band model = dataService.GetBandById(id);
            return View(model);
        }
    }
}
