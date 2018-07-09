namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePerformersTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Performers] ON
INSERT INTO [dbo].[Performers] ([Id], [Name], [Description], [PerformerTypeId], [TourName], [GenreId], [TopicId], [IsActive]) VALUES (1, N'Yo-Yo Ma', N'Famous Cellist', 1, N'Silk Road Project!!!', NULL, NULL, 1)
INSERT INTO [dbo].[Performers] ([Id], [Name], [Description], [PerformerTypeId], [TourName], [GenreId], [TopicId], [IsActive]) VALUES (2, N'New York Philharmonic', N'Famous Orchestra from NYC', 1, N'Americana', NULL, NULL, 1)
INSERT INTO [dbo].[Performers] ([Id], [Name], [Description], [PerformerTypeId], [TourName], [GenreId], [TopicId], [IsActive]) VALUES (3, N'AC/DC', N'Famous Band', 1, N'Back from the Dead', NULL, NULL, 1)
INSERT INTO [dbo].[Performers] ([Id], [Name], [Description], [PerformerTypeId], [TourName], [GenreId], [TopicId], [IsActive]) VALUES (4, N'Kelly Carkson', N'Famous Singer', 1, N'Meaning of Life', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Performers] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
