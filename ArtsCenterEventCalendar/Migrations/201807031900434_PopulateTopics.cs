namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTopics : DbMigration
    {
        public override void Up()
        {
            Sql(@"
SET IDENTITY_INSERT [dbo].[Topics] ON
INSERT INTO [dbo].[Topics] ([Id], [Name]) VALUES (1, N'Happiness')
INSERT INTO [dbo].[Topics] ([Id], [Name]) VALUES (2, N'Personal Growth')
INSERT INTO [dbo].[Topics] ([Id], [Name]) VALUES (3, N'Leadership')
INSERT INTO [dbo].[Topics] ([Id], [Name]) VALUES (4, N'Discipline')
INSERT INTO [dbo].[Topics] ([Id], [Name]) VALUES (5, N'Perserverence')
INSERT INTO [dbo].[Topics] ([Id], [Name]) VALUES (6, N'Marketing')
INSERT INTO [dbo].[Topics] ([Id], [Name]) VALUES (7, N'Anti-Drug')
INSERT INTO [dbo].[Topics] ([Id], [Name]) VALUES (8, N'Family')
INSERT INTO [dbo].[Topics] ([Id], [Name]) VALUES (9, N'Political')
INSERT INTO [dbo].[Topics] ([Id], [Name]) VALUES (10, N'Protest')
SET IDENTITY_INSERT [dbo].[Topics] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
