using static System.Net.Mime.MediaTypeNames;

namespace DogsMvc.Models
{
    public class DataService
    {
        List<Dog> dogs = new List<Dog>
		{

         new Dog {Id = 1, Name = "Golden Retriever", Age = 10},
         new Dog {Id = 2, Name = "French Bulldog", Age = 5 },
		 new Dog {Id = 3, Name = "German Shepherd", Age = 2 },
         new Dog {Id = 4, Name = "Rottweiler", Age = 9 },
         new Dog {Id = 5, Name = "Beagle", Age = 4 },
         
        };

		public Dog AddDog(int id, string name, int age)
		{
		
			return dogs.Add();
		}
		public Dog[] GetAllDogs()
		{
			return dogs.ToArray();
		}
		public Dog[] GetDogById(int id)
		{
			return dogs.ToArray();
		}

	}
}
