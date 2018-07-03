namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReaddGenreAddTopic : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Performers", "GenreId", c => c.Int());
            AddColumn("dbo.Performers", "TopicId", c => c.Int());
            CreateIndex("dbo.Performers", "GenreId");
            CreateIndex("dbo.Performers", "TopicId");
            AddForeignKey("dbo.Performers", "GenreId", "dbo.Genres", "Id");
            AddForeignKey("dbo.Performers", "TopicId", "dbo.Topics", "Id");
            DropColumn("dbo.Performers", "Genre");
            DropColumn("dbo.Performers", "Topic");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Performers", "Topic", c => c.String());
            AddColumn("dbo.Performers", "Genre", c => c.String());
            DropForeignKey("dbo.Performers", "TopicId", "dbo.Topics");
            DropForeignKey("dbo.Performers", "GenreId", "dbo.Genres");
            DropIndex("dbo.Performers", new[] { "TopicId" });
            DropIndex("dbo.Performers", new[] { "GenreId" });
            DropColumn("dbo.Performers", "TopicId");
            DropColumn("dbo.Performers", "GenreId");
            DropTable("dbo.Topics");
            DropTable("dbo.Genres");
        }
    }
}
