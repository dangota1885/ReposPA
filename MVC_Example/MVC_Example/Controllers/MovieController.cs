using MVC_Example.Models;
using MVC_Example.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Example.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/random
        public ActionResult Random()
        {
            var movie = new Movie() { Name="Titanic"};
            var customers = new List<Customer>
            {
                new Customer{Name ="Customer 1"},
                new Customer{Name ="Customer 2"}
            };

            var viewModel = new RandomMovieViewModel {
                Movie = movie,
                Customers= customers
            };

            return View(viewModel);
        }
        public ActionResult Edit(int id)
        {
            return Content("id:" + id);
        }
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content("Year:" + year + " month:" + month);
        }
    }
}