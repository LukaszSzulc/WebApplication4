using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=DatabaseConnection")
        {
            
        }

        public DbSet<Person> Persons { get; set; }
    }
}