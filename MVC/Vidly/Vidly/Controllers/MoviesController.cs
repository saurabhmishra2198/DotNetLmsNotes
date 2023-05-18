using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Ramdom
        public ActionResult Random()
        {
            var movie = new List<Movie>() 
            { 
               new Movie{ Name = "Shrek" },
               new Movie {Name = "Wall-e"},
            };
            var customers = new List<Customer>
            {
                new Customer{Id = 1, Name = "John Smith"},
                new Customer{Id = 2, Name = "Mary Williams"},
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movies = movie,
                Customers = customers
            }; 

            return View(viewModel);
            
        }
        

    }
}