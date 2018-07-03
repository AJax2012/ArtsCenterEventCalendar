namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveInheritenceFromPerformer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Performers", "GenreId", "dbo.Genres");
            DropIndex("dbo.Performers", new[] { "GenreId" });
            AddColumn("dbo.Performers", "Genre", c => c.String());
            AddColumn("dbo.Performers", "Topic", c => c.String());
            AlterColumn("dbo.Venues", "Name", c => c.String());
            DropColumn("dbo.Performers", "GenreId");
            DropTable("dbo.Genres");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Performers", "GenreId", c => c.Int(nullable: false));
            AlterColumn("dbo.Venues", "Name", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Performers", "Topic");
            DropColumn("dbo.Performers", "Genre");
            CreateIndex("dbo.Performers", "GenreId");
            AddForeignKey("dbo.Performers", "GenreId", "dbo.Genres", "Id");
        }
    }
}
