using static System.Net.Mime.MediaTypeNames;

namespace DogsMvc.Models
{
    public class DataService
    {
        List<Dogs> dog = new List<Dogs>
		{

         new Dogs {Id = 1, Name = "Golden Retriever", Age = 10},
         new Dogs {Id = 2, Name = "French Bulldog", Age = 5 },
		 new Dogs {Id = 3, Name = "German Shepherd", Age = 2 },
         new Dogs {Id = 4, Name = "Rottweiler", Age = 9 },
         new Dogs {Id = 5, Name = "Beagle", Age = 4 },
         
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
