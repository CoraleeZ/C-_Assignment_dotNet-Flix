using Microsoft.EntityFrameworkCore;

namespace Dotnet_Flix.Models
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Useres { get; set; }
        public DbSet<Movie> Moviees { get; set; }
        public DbSet<Rate> Ratees { get; set; }
        public DbSet<Check_out> Check_outes { get; set; }


    }
}