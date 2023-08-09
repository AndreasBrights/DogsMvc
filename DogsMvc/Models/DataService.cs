using static System.Net.Mime.MediaTypeNames;

namespace WebApplication1.Models
{
    public class DataService
    {
        List<Dogs> og = new List<Dogs>
		{

         new Dogs {Id = 1, Name = "" },
         new Dogs {Id = 2, Name = "" },
		 new Dogs {Id = 3, Name = "" },
         new Dogs {Id = 4, Name = "" },
         new Dogs {Id = 5, Name = "" },
         
        };

        //public Dogs GetBandById(int id)
        //{
        //    return bands.SingleOrDefault(band => band.Id == id);
                
        //}
        //public Dogs[] GetAllBands()
        //{
        //    return bands.ToArray();
        //}

      
    }
}
