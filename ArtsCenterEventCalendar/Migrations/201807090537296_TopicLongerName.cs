namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TopicLongerName : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Topics", new[] { "Name" });
            AlterColumn("dbo.Topics", "Name", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Topics", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Topics", new[] { "Name" });
            AlterColumn("dbo.Topics", "Name", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.Topics", "Name", unique: true);
        }
    }
}
