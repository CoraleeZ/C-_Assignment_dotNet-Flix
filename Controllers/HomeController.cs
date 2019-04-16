using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dotnet_Flix.Models;
/////
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
////

namespace Dotnet_Flix.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        //////////////////////////////////////////////////
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            Login_Register_wrapper wrapper=new Login_Register_wrapper();
            return View(wrapper);
        }

        [HttpPost("process_register")]
        public IActionResult Process_Register(User reg)
        {
            // Check initial ModelState
            if(ModelState.IsValid)
            {
                // If a User exists with provided email
                if(dbContext.Useres.Any(u => u.Email == reg.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");
                    
                    // You may consider returning to the View at this point
                    Login_Register_wrapper wrapper=new Login_Register_wrapper();
                    return View("Index",wrapper);
                }
                else{
                    HttpContext.Session.SetString("Firstname", reg.Firstname);
                    //////
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    reg.Password = Hasher.HashPassword(reg, reg.Password);
                    //////
                    dbContext.Add(reg);
                    dbContext.SaveChanges(); 
                    User newuser=dbContext.Useres
                    .FirstOrDefault(u=>u.Email==reg.Email);
                    HttpContext.Session.SetInt32("id",newuser.UserId);
                    return RedirectToAction("Dashboard");
                }
            }else{
                Login_Register_wrapper wrapper=new Login_Register_wrapper();
                return View("Index",wrapper);
            }
            // other code
        } 

        [HttpPost("process_login")]
        public IActionResult Process_Login(Login log)
        {
            if(ModelState.IsValid)
            {
               
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.Useres.FirstOrDefault(u => u.Email == log.logEmail);
                // If no user exists with provided email          
                if(userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("logEmail", "Invalid Email/Password");
                    Login_Register_wrapper wrapper=new Login_Register_wrapper();
                    return View("Index",wrapper);
                }else{
                    // Initialize hasher object
                    var hasher = new PasswordHasher<Login>();
                    
                    // varify provided password against hash stored in db
                    var result = hasher.VerifyHashedPassword(log, userInDb.Password, log.logPassword);
                    
                    // result can be compared to 0 for failure    
                    if(result == 0)
                    { 
                      
                        // handle failure (this should be similar to how "existing email" is handled)
                        ModelState.AddModelError("logPassword", "Invalid Email/Password");
                        Login_Register_wrapper wrapper=new Login_Register_wrapper();
                        return View("Index",wrapper);              
                    }
                    else{                
                       
                        HttpContext.Session.SetString("Firstname", userInDb.Firstname);
                        HttpContext.Session.SetInt32("id",userInDb.UserId);
                        return RedirectToAction("Dashboard"); 
                    }
                }
            }else{
                Login_Register_wrapper wrapper=new Login_Register_wrapper();
                return View("Index",wrapper);
            }

        }
        
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Firstname");
            HttpContext.Session.Remove("id");

            return RedirectToAction("Index");
        }


//////////////////////////////////////////////////////////////////////////////
        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if(HttpContext.Session.GetString("Firstname")!=null){
                User user=dbContext.Useres
                .Include(u=>u.MoviesInHand)
                .ThenInclude(c=>c.Movie)
                .FirstOrDefault(u=>u.UserId==(int)HttpContext.Session.GetInt32("id"));
                // System.Console.WriteLine("ID:!!!:"+(int)HttpContext.Session.GetInt32("id"));
                int num=dbContext.Ratees
                .Where(r=>r.UserId==(int)HttpContext.Session.GetInt32("id"))
                .ToList()
                .Count;

                dashboard_wrapper dashboard_wrapper=new dashboard_wrapper{
                    User=user,
                    Watched=num
                };

                return View(dashboard_wrapper);
            }else{
                return RedirectToAction("Index");
            }
        }

        [HttpGet("movies/{MovieId}")]
        public IActionResult Display_movie(int MovieId)
        {
            if(HttpContext.Session.GetString("Firstname")!=null){
                Movie onemovie=dbContext.Moviees
                .Include(m=>m.check_person)
                .FirstOrDefault(m=>m.MovieId==MovieId);

                double ave_rate=-1;
                if(dbContext.Ratees.Any(r=>r.MovieId==MovieId))
                {
                    ave_rate = dbContext.Ratees
                    .Where(r=>r.MovieId==MovieId)
                    .Select(r=>r.rate).ToList().Average();
                }

                User user=dbContext.Useres
                .Include(u=>u.WatchedMovies)
                .FirstOrDefault(u=>u.UserId==(int)HttpContext.Session.GetInt32("id"));

                double your_rate=-1;
                if( user.WatchedMovies.Any(w=>w.MovieId==MovieId))
                {
                    your_rate=user.WatchedMovies
                    .Where(w=>w.MovieId==MovieId)
                    .Select(w=>w.rate).ToList().Average();
                }
                
                int number_of_movieinhand=dbContext.Useres
                .Include(u=>u.MoviesInHand)
                .FirstOrDefault(u=>u.UserId==(int)HttpContext.Session.GetInt32("id"))
                .MoviesInHand
                .Count;

                Display_movie_wrapper Display_movie_wrapper=new Display_movie_wrapper
                {
                    OneMovie=onemovie,
                    Ave_rate=ave_rate,
                    Your_rate=your_rate,
                    Number_of_MovieInHand=number_of_movieinhand,
                    Userid=(int)HttpContext.Session.GetInt32("id")
                };
                
                return View(Display_movie_wrapper);
            }else{
                return RedirectToAction("Index");
            }
        }


        [HttpGet("new")]
        public IActionResult Addnewmovie()
        {
            if(HttpContext.Session.GetString("Firstname")!=null){
                List<Movie> allmovie=dbContext.Moviees
                .Include(m=>m.check_person)
                .ToList();
                List<Movie> avaiablemovie=new List<Movie>();
                foreach(Movie x in allmovie)
                {
                    if(x.check_person.All(c=>c.UserId!=(int)HttpContext.Session.GetInt32("id")))
                    {
                        avaiablemovie.Add(x);
                    }
                }

                Addnewmovie Addnewmovie=new Addnewmovie
                {
                    AvaiableMovie=avaiablemovie,
                };
                return View(Addnewmovie);
            }else{
                return RedirectToAction("Index");
            }
        }

        [HttpPost("process_newmovie")]
        public IActionResult Process_NewMovie(Movie movie)
        {
            if(HttpContext.Session.GetString("Firstname")!=null){
                if(movie.Released<DateTime.Now && movie.Released>new DateTime(1888,1,1)){
                    
                    dbContext.Add(movie);
                    dbContext.SaveChanges();

                    return RedirectToAction("Addnewmovie");
                }
                else{
                    ModelState.AddModelError("Released", "Released date should between 1888 and present.");
                    
                    List<Movie> allmovie=dbContext.Moviees
                    .Include(m=>m.check_person)
                    .ToList();
                    List<Movie> avaiablemovie=new List<Movie>();
                    foreach(Movie x in allmovie)
                    {
                        if(x.check_person.All(c=>c.UserId!=(int)HttpContext.Session.GetInt32("id")))
                        {
                            avaiablemovie.Add(x);
                        }
                    }

                    Addnewmovie Addnewmovie=new Addnewmovie
                    {
                        AvaiableMovie=avaiablemovie,
                        Movie=movie,
                    };

                    return View("Addnewmovie",Addnewmovie);
                }
            }else{
                return RedirectToAction("Index");
            }
        }

        [HttpGet("checkout/{MovieId}")]
        public IActionResult Check_out(int MovieId)
        {
            if(HttpContext.Session.GetString("Firstname")!=null){
                Check_out check_out=new Check_out();
                check_out.UserId=(int)HttpContext.Session.GetInt32("id");
                check_out.MovieId=MovieId;
                dbContext.Add(check_out);
                dbContext.SaveChanges();
                return RedirectToAction("Addnewmovie");
            }else{
                return RedirectToAction("Index");
            }
        }

        [HttpGet("returnpage/{MovieId}")]
        public IActionResult Return_page(int MovieId)
        {
            if(HttpContext.Session.GetString("Firstname")!=null){
                int movieId=MovieId;
                return View(movieId);
            }else{
                return RedirectToAction("Index");
            }
        }

        [HttpPost("return/{MovieId}")]
        public IActionResult Process_Return(int MovieId, int rate)
        {
            if(HttpContext.Session.GetString("Firstname")!=null){
                Rate Rate=new Rate();
                Rate.rate=rate;
                Rate.MovieId=MovieId;
                Rate.UserId=(int)HttpContext.Session.GetInt32("id");
                dbContext.Add(Rate);
                dbContext.SaveChanges();

                Check_out ReturnOne=dbContext.Check_outes
                .Where(c=>c.UserId==(int)HttpContext.Session.GetInt32("id"))
                .FirstOrDefault(c=>c.MovieId==MovieId);
                dbContext.Check_outes.Remove(ReturnOne);
                dbContext.SaveChanges();

                return RedirectToAction("Dashboard");
            }else{
                return RedirectToAction("Index");
            }
        }

    }
}
