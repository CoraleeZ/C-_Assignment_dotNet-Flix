using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dotnet_Flix.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        [MinLength(3, ErrorMessage="Title name must be 3 characters or longer!")]
        public string Title { get; set; }
        [Required]
        [MinLength(1, ErrorMessage="Genre can not be empty !")]
        public string Genre { get; set; }
        [Required]
        public DateTime Released { get; set; }
        public List<Rate> Rates { get; set; }
        public List<Check_out> check_person { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }


}