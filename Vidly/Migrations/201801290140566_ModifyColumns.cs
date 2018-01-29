namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "DateAdd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "DateAdd", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "DateAdded");
        }
    }
}
