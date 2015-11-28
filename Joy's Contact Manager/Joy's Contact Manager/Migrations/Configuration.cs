namespace Joy_Contact_Manager.Migrations

{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Joy_Contact_Manager.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<Joy_Contact_Manager.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Joy_Contact_Manager.Models.ApplicationDbContext context)
        {
            context.Contacts.AddOrUpdate(p => p.Name,
        new Contact
        {
            Name = "Joy Earl",
            Address = "16819 NW Wapato Ave",
            City = "Portland",
            State = "OR",
            Zip = "97231",
            Email = "joyrockon@gmail.com",
        },
         new Contact
         {
             Name = "Thorsten Weinrich",
             Address = "5678 1st Ave W",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Email = "thorsten@example.com",
         },
         new Contact
         {
             Name = "Yuhong Li",
             Address = "9012 State st",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Email = "yuhong@example.com",
         },
         new Contact
         {
             Name = "Jon Orton",
             Address = "3456 Maple St",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Email = "jon@example.com",
         },
         new Contact
         {
             Name = "Diliana Alexieva-Bosseva",
             Address = "7890 2nd Ave E",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Email = "diliana@example.com",
         }
         );

        }
    }
}
