using WebApplication4.Models;

namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication4.Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication4.Models.DatabaseContext context)
        {
            context.Persons.Add(new Person {FirstName = "Lukasz", LastName = "Szulc"});
            context.SaveChanges();
        }
    }
}
