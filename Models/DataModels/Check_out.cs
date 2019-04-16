using System.ComponentModel.DataAnnotations;

namespace Dotnet_Flix.Models
{
    public class Check_out
    {
        [Key]
        public int Check_outId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

    }


}