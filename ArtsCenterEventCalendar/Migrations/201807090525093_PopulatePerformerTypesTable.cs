namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePerformerTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[PerformerTypes] ON
INSERT INTO [dbo].[PerformerTypes] ([Id], [Name]) VALUES (1, N'Music')
INSERT INTO [dbo].[PerformerTypes] ([Id], [Name]) VALUES (2, N'Comedy')
INSERT INTO [dbo].[PerformerTypes] ([Id], [Name]) VALUES (3, N'Theater')
INSERT INTO [dbo].[PerformerTypes] ([Id], [Name]) VALUES (4, N'Musical Theater')
INSERT INTO [dbo].[PerformerTypes] ([Id], [Name]) VALUES (5, N'Motivational Speaker')
INSERT INTO [dbo].[PerformerTypes] ([Id], [Name]) VALUES (6, N'Pannel')
SET IDENTITY_INSERT [dbo].[PerformerTypes] OFF");
        }
        
        public override void Down()
        {
        }
    }
}
