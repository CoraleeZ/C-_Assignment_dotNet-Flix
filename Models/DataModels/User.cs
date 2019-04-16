using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet_Flix.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MinLength(3,ErrorMessage="Firstname must be 3 characters or longer!")]
        [MaxLength(50,ErrorMessage="Firstname must less than 50 characters!")]
        public string Firstname { get; set; }
        [Required]
        [MinLength(3,ErrorMessage="Lastname must be 3 characters or longer!")]
        [MaxLength(50,ErrorMessage="Lastname must less than 50 characters!")]
        public string Lastname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        // [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        // [MaxLength(20, ErrorMessage="Password must less than 20 characters!")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+]).{8,20}$",ErrorMessage="Password must between 8-20 characters and contains at least 1 upper letter, 1 lower letter, and 1 special character.")]
        public string Password { get; set; }
        // [DisplayFormat(ApplyFormatInEditMode=true,DataFormatString="{0:MM/dd/yyyy}")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        // [DisplayFormat(ApplyFormatInEditMode=true,DataFormatString="{0:MM/dd/yyyy}")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Rate> WatchedMovies { get; set; }
        public List<Check_out> MoviesInHand { get; set; }

        [NotMapped]
        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string C_Password { get; set; }
    }


}