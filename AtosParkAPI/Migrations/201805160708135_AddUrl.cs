namespace AtosParkAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Url");
        }
    }
}
