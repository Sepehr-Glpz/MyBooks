namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version10 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Library Books", name: "Name", newName: "Book Name");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Library Books", name: "Book Name", newName: "Name");
        }
    }
}
