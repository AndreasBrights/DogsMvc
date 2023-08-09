using Microsoft.AspNetCore.Mvc;
using DogsMvc.Models;

namespace DogsMvc.Controllers
{
    public class DogsController : Controller
    {
        static DataService dataService = new DataService(); 

        public DogsController()
        {
            //dataService = new DataService();
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            var model = dataService.GetAllDogs();
            return View(model);
        }
        [HttpGet("/{id}")]
        public IActionResult ShowDogs(int id)
        {
            var model = dataService.GetDogById(id);
            return View(model);
        }
	

		[HttpPost("/ShowDogs")]
		public IActionResult AddDogToArray(Dog dog)
		{
			var model = dataService.AddDog(dog.Id, dog.Name, dog.Age);
            return RedirectToAction("AfterDogAdded", model);
		}

		[HttpGet("/AfterDogAdded")]
		public IActionResult AfterDogAdded(Dog dog)
		{
			//var model = dataService.AddDog(dog.Id, dog.Name, dog.Age);
			return View(dog);
		}
	}
}
