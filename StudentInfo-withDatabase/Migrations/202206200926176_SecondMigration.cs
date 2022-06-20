namespace StudentInfo_withDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Mark", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Mark");
        }
    }
}
