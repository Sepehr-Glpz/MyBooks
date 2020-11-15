using System;
using System.Data.Entity.Migrations;
namespace Models.Migrations
{
   
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Library Books",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Author = c.String(maxLength: 20),
                        Year = c.Int(),
                        BookGenre = c.Int(name: "Book Genre", nullable: false),
                        BookType = c.Short(name: "Book Type", nullable: false),
                        Description = c.String(maxLength: 1024),
                        OwnerUserId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.OwnerUserId)
                .Index(t => t.OwnerUserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Username = c.String(nullable: false, maxLength: 20),
                        UserPassword = c.String(name: "User Password", nullable: false, maxLength: 25),
                        Description = c.String(maxLength: 1024),
                        FullName_FirstName = c.String(),
                        FullName_LastName = c.String(),
                        SystemAdmin = c.Boolean(name: "System Admin", nullable: false),
                        Admin = c.Boolean(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Library Books", "OwnerUserId", "dbo.Users");
            DropIndex("dbo.Library Books", new[] { "OwnerUserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Library Books");
        }
    }
}
