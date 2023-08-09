using Microsoft.AspNetCore.Mvc;
using DogsMvc.Models;

namespace DogsMvc.Controllers
{
    public class DogsController : Controller
    {
        DataService dataService; //static 

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
