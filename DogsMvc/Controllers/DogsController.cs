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

        [HttpGet("/")]
        public IActionResult Index()
        {
            var model = dataService.GetAllDogs();
            return View(model);
        }
        [HttpGet("/{id}")]
        public IActionResult Details(int id)
        {
            var model = dataService.GetDogById(id);
            return View(model);
        }

    }
}
