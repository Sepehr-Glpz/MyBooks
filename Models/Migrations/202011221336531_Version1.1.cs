namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Library Books", "Book Name", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Library Books", "Book Name", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
