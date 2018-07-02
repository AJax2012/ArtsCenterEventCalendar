namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePerformersTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"
SET IDENTITY_INSERT [dbo].[Performers] ON
INSERT INTO [dbo].[Performers] ([Id], [Name], [PerformerTypeId], [Description], [GenreId], [TourName]) VALUES (1, N'Yo-Yo Ma', 1, N'Famous Cellist', 2, N'Silk Road Project')
INSERT INTO [dbo].[Performers] ([Id], [Name], [PerformerTypeId], [Description], [GenreId], [TourName]) VALUES (2, N'New York Philharmonic', 1, N'Famous Orchestra from NYC', 1, N'Americana')
INSERT INTO [dbo].[Performers] ([Id], [Name], [PerformerTypeId], [Description], [GenreId], [TourName]) VALUES (3, N'AC/DC', 1, N'Famous Band', 3, N'Back from the Dead')
INSERT INTO [dbo].[Performers] ([Id], [Name], [PerformerTypeId], [Description], [GenreId], [TourName]) VALUES (4, N'Kelly Carkson', 1, N'Famous Singer', 4, N'Meaning of Life')
INSERT INTO [dbo].[Performers] ([Id], [Name], [PerformerTypeId], [Description], [GenreId], [TourName]) VALUES (5, N'Sonny Rollins', 1, N'Famous Saxiphonist', 10, N'Saxing it UP!')
SET IDENTITY_INSERT [dbo].[Performers] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
