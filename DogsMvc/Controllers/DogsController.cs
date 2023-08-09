using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DogsController : Controller
    {
        DataService dataService;

        public DogsController()
        {
            dataService = new DataService();
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var model = dataService.GetAllBands();
            return View(model);
        }
        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var model = dataService.GetBandById(id);
            return View(model);
        }

    }
}
