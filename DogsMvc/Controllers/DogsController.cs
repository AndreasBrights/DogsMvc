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

		[HttpGet("/Create")]
		public IActionResult Create(Dog dog)
		{
			return View(dog);
		}

		[HttpPost("/AddDog")]
		public IActionResult AddDog(Dog dog)
		{
			dataService.AddDog(dog);
			return RedirectToAction(nameof(Index));
		}
		//[HttpGet("/ShowDogs")]
		//public IActionResult ShowDogs()
		//{

		//	var model = dataService.GetAllDogs();
		//	return View(model);
		//}
	}
}

