using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public ICollection<Movie> Movies { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}