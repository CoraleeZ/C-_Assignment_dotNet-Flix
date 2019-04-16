using System.ComponentModel.DataAnnotations;

namespace Dotnet_Flix.Models
{
    public class Rate
    {
        [Key]
        public int RateId { get; set; }
        public int rate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

    }


}