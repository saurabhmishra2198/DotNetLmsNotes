﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set;}
        public DbSet<Movie> Movies { get; set;}
    }
}