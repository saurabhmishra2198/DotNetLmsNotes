﻿using System.Data.Entity;

namespace CodeFirstApproach.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
