using System.Collections.Generic;
namespace Dotnet_Flix.Models
{
    public class Display_movie_wrapper
    {
        public Movie OneMovie { get; set; }
        public double Ave_rate { get; set; }
        public double Your_rate { get; set; }
        public int Number_of_MovieInHand { get; set; }
        public int Userid { get; set; }
    }
}