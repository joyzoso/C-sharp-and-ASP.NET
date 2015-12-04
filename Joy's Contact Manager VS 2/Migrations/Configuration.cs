namespace Joy_Contact_Manager.Migrations

{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Joy_Contact_Manager.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;


    internal sealed class Configuration : DbMigrationsConfiguration<Joy_Contact_Manager.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        bool AddUserAndRole(Joy_Contact_Manager.Models.ApplicationDbContext context)
        {
            IdentityResult ir;
            var rm = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>(context));
            ir = rm.Create(new IdentityRole("canEdit"));
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "brullen",
            };
            ir = um.Create(user, "brullen7");
            if (ir.Succeeded == false)
                return ir.Succeeded;
            ir = um.AddToRole(user.Id, "canEdit");
            return ir.Succeeded;

        }

        protected override void Seed(Joy_Contact_Manager.Models.ApplicationDbContext context)
        {
            //adds a new role called canedit and creates a new user, brullen and adds that to the canedit role
            AddUserAndRole(context);

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
