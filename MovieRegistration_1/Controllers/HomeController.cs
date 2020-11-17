using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace MovieRegistration_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            private static List<Movie> _movies = GetMovies();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Register(Movie newMovie)
        {
            _movies.Add(newMovie);

            return View("Submitted", newMovie);
        }

        public IActionResult MovieList()
        {
            return View(_movies);
        }
        public IActionResult Search()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private static List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie(1, "Avengers", 2012, "Tony Stark", "Katara", new List<string>{"Action","Animation","Comedy"}),
                new Movie(2, "Shrek", 2001, "Strek", "Feona", new List<string>{ "Comedy", "Animation"}),
                new Movie(3, "Hunger Games", 2012, "Katniss", "Peeta", new List<string>{"Action", "Drama"}),
                new Movie(4, "Spiderman 3", 2007, "Peter Parker", "Aunt May", new List<string>{"Comedy", "Animation"}),
                new Movie(5, "Saw II", 2005, "Jigsaw", "Amanda", new List<string>{"Action", "Drama", "Horror"}),
                new Movie(6, "Cars 3", 2017, "Cruz", "Lightning McQueen", new List<string>{"Comedy", "Action","Animation"}),
                new Movie(7, "Batman v Superman", 2016, "Batman", "Superman", new List<string>{"Action", "Drama"}),
                new Movie(8, "Justice League", 2017, "The Flash", "Wonder Woman", new List<string>{ "Action"}),
                new Movie(9, "Mutant Ninja Turtles", 2014, "Raphael", "Donatello", new List<string>{"Comedy", "Drama", "Action"}),
                new Movie(10, "This Christmas", 2007, "Ma'Dere", "Michael", new List<string>{"Comedy", "Drama"}),
            };
        }
    }
}
