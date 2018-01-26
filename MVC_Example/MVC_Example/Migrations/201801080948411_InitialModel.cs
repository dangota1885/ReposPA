namespace MVC_Example.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "Customer");
            RenameTable(name: "dbo.Movies", newName: "Movie");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Movie", newName: "Movies");
            RenameTable(name: "dbo.Customer", newName: "Customers");
        }
    }
}
