namespace EFWebAPI.Migrations.ContextA
{ 

using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using EFWebAPI.Models;



    internal sealed class Configuration : DbMigrationsConfiguration<EFWebAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ContextA";
        }



        public void Seed(EFWebAPI.Models.EFWebAPIContext context)
        {
            context.Circles.AddOrUpdate(x => x.Id,

        new Circle() { Id = 1, Name = "Music" },
        new Circle() { Id = 2, Name = "Work" },
        new Circle() { Id = 3, Name = "School" },
        new Circle() { Id = 4, Name = "Family" }
        );

            context.Penpals.AddOrUpdate(x => x.Id,
                new Penpal()
                {
                    Id = 1,
                    Name = "Nadia Earl",
                    Email = "nadearl@yahoo.com",
                    StreetAddy = "927 NW 10th Court",
                    CityStateZip = "Miami, FL 33136"
                   
                },
                new Penpal()
                {
                    Id = 3,
                    Name = "Bojana Skarich",
                    Email = "lalala@yahoo.com",
                    StreetAddy = "124 Main Street",
                    CityStateZip = "Portland, OR 98273"
                
                },
                 new Penpal()
                 {
                     Id = 3,
                     Name = "Beth Larivere",
                     Email = "lalala@yahoo.com",
                     StreetAddy = "124 Main Street",
                     CityStateZip = "Portland, OR 98273"

                 },
                new Penpal()
                {
                    Id = 4,
                    Name = "Dan Earl",
                    Email = "lalala@yahoo.com",
                    StreetAddy = "124 Main Street",
                    CityStateZip = "Portland, OR 98273"

                }
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
