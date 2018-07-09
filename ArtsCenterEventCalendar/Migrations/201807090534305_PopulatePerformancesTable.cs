namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePerformancesTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Performances] ON
INSERT INTO [dbo].[Performances] ([Id], [SeatsRemaining], [Price], [Description], [EventDateTime], [PerformerId], [VenueId], [IsActive]) VALUES (1, 1500, CAST(60.00 AS Decimal(6, 2)), N'Fun', N'2018-07-15 19:30:00', 2, 2, 1)
INSERT INTO [dbo].[Performances] ([Id], [SeatsRemaining], [Price], [Description], [EventDateTime], [PerformerId], [VenueId], [IsActive]) VALUES (2, 1300, CAST(70.00 AS Decimal(6, 2)), N'Fun', N'2018-07-16 18:00:00', 4, 4, 1)
INSERT INTO [dbo].[Performances] ([Id], [SeatsRemaining], [Price], [Description], [EventDateTime], [PerformerId], [VenueId], [IsActive]) VALUES (3, 1500, CAST(79.00 AS Decimal(6, 2)), N'Fun', N'2018-07-09 18:30:00', 1, 2, 1)
INSERT INTO [dbo].[Performances] ([Id], [SeatsRemaining], [Price], [Description], [EventDateTime], [PerformerId], [VenueId], [IsActive]) VALUES (4, 1500, CAST(89.00 AS Decimal(6, 2)), N'Fun', N'2018-07-20 20:00:00', 3, 4, 1)
SET IDENTITY_INSERT [dbo].[Performances] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
