namespace MVC_Example.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipType",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customer", "MembershipType_Id", c => c.Byte());
            CreateIndex("dbo.Customer", "MembershipType_Id");
            AddForeignKey("dbo.Customer", "MembershipType_Id", "dbo.MembershipType", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customer", "MembershipType_Id", "dbo.MembershipType");
            DropIndex("dbo.Customer", new[] { "MembershipType_Id" });
            DropColumn("dbo.Customer", "MembershipType_Id");
            DropTable("dbo.MembershipType");
        }
    }
}
