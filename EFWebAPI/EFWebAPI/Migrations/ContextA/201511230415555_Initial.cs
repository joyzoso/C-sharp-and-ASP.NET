namespace EFWebAPI.Migrations.ContextA
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Circles",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id);


            CreateTable(
                "dbo.Penpals",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Email = c.String(nullable: false),
                    StreetAddy = c.String(nullable: false),
                    CityStateZip = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Circles", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Penpals", "CircleId", "dbo.Circles");
           
            DropIndex("dbo.Penpals", new[] { "CircleId" });
           
          
            DropTable("dbo.Penpals");
          
            DropTable("dbo.Circles");
        }
    }
}
