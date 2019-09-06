namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_activation_code1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ActivationToken", c => c.String());
            AddColumn("dbo.Users", "IsActive", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Users", "created_at", c => c.DateTime());
            AlterColumn("dbo.Users", "updated_at", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "updated_at", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "created_at", c => c.DateTime(nullable: false));
            DropColumn("dbo.Users", "IsActive");
            DropColumn("dbo.Users", "ActivationToken");
        }
    }
}
