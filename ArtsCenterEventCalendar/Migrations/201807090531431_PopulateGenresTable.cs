namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Genres] ON
INSERT INTO [dbo].[Genres] ([Id], [Name]) VALUES (1, N'Classical (Orchestra)')
INSERT INTO [dbo].[Genres] ([Id], [Name]) VALUES (2, N'Classical (Solo)')
INSERT INTO [dbo].[Genres] ([Id], [Name]) VALUES (3, N'Classic Rock')
INSERT INTO [dbo].[Genres] ([Id], [Name]) VALUES (4, N'Alternative Rock')
INSERT INTO [dbo].[Genres] ([Id], [Name]) VALUES (5, N'Hard Rock')
INSERT INTO [dbo].[Genres] ([Id], [Name]) VALUES (6, N'Rock & Roll')
INSERT INTO [dbo].[Genres] ([Id], [Name]) VALUES (7, N'Metal')
INSERT INTO [dbo].[Genres] ([Id], [Name]) VALUES (8, N'Heavy Metal')
INSERT INTO [dbo].[Genres] ([Id], [Name]) VALUES (9, N'Blues')
INSERT INTO [dbo].[Genres] ([Id], [Name]) VALUES (10, N'Jazz')
SET IDENTITY_INSERT [dbo].[Genres] OFF");
        }
        
        public override void Down()
        {
        }
    }
}
