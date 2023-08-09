using static System.Net.Mime.MediaTypeNames;

namespace DogsMvc.Models
{
    public class DataService
    {
        List<Dogs> dog = new List<Dogs>
		{

         new Dogs {Id = 1, Name = "Golden Retriever" },
         new Dogs {Id = 2, Name = "French Bulldog" },
		 new Dogs {Id = 3, Name = "German Shepherd" },
         new Dogs {Id = 4, Name = "Rottweiler" },
         new Dogs {Id = 5, Name = "Beagle" },
         
        };

		public Dogs AddDog(int id)
		{
			return dog.SingleOrDefault(dog => dog.Id == id);

		}
		public Dogs[] GetAllDogs()
		{
			return dog.ToArray();
		}
		public Dogs[] GetDogById(int id)
		{
			return dog.ToArray();
		}

	}
}
