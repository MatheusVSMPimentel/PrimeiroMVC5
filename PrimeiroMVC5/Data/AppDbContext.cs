using PrimeiroMVC5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrimeiroMVC5.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefautlConnection") { }

        public DbSet<Student> Students { get; set; }
    }
}