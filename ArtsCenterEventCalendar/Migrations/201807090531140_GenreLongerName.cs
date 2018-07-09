namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreLongerName : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Genres", new[] { "Name" });
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Genres", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Genres", new[] { "Name" });
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.Genres", "Name", unique: true);
        }
    }
}
