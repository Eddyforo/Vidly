namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MembershipType_SignUpFee", c => c.Short(nullable: false));
            AddColumn("dbo.Customers", "MembershipType_DurationInMonths", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MembershipType_DiscountRate", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "MembershipTypeId");
            DropColumn("dbo.Customers", "MembershipType_DiscountRate");
            DropColumn("dbo.Customers", "MembershipType_DurationInMonths");
            DropColumn("dbo.Customers", "MembershipType_SignUpFee");
        }
    }
}
