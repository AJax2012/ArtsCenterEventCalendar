namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePerformancesTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"
SET IDENTITY_INSERT [dbo].[Performances] ON
INSERT INTO [dbo].[Performances] ([Id], [EventDateTime], [Price], [Description], [VenueId], [SeatsRemaining], [PerformerId]) VALUES (1, N'2018-07-10 18:30:00', CAST(70.00 AS Decimal(6, 2)), N'Fun Times', 1, 3000, 1)
INSERT INTO [dbo].[Performances] ([Id], [EventDateTime], [Price], [Description], [VenueId], [SeatsRemaining], [PerformerId]) VALUES (2, N'2018-07-15 19:30:00', CAST(60.00 AS Decimal(6, 2)), N'Fun', 2, 1500, 2)
INSERT INTO [dbo].[Performances] ([Id], [EventDateTime], [Price], [Description], [VenueId], [SeatsRemaining], [PerformerId]) VALUES (3, N'2018-07-13 19:00:00', CAST(55.00 AS Decimal(6, 2)), N'Fun', 3, 1200, 3)
INSERT INTO [dbo].[Performances] ([Id], [EventDateTime], [Price], [Description], [VenueId], [SeatsRemaining], [PerformerId]) VALUES (4, N'2018-07-16 18:00:00', CAST(70.00 AS Decimal(6, 2)), N'Fun', 4, 1300, 4)
INSERT INTO [dbo].[Performances] ([Id], [EventDateTime], [Price], [Description], [VenueId], [SeatsRemaining], [PerformerId]) VALUES (5, N'2018-07-08 19:30:00', CAST(75.00 AS Decimal(6, 2)), N'Fun', 1, 3500, 5)
INSERT INTO [dbo].[Performances] ([Id], [EventDateTime], [Price], [Description], [VenueId], [SeatsRemaining], [PerformerId]) VALUES (6, N'2018-07-09 18:30:00', CAST(79.00 AS Decimal(6, 2)), N'Fun', 2, 1500, 1)
INSERT INTO [dbo].[Performances] ([Id], [EventDateTime], [Price], [Description], [VenueId], [SeatsRemaining], [PerformerId]) VALUES (7, N'2018-07-18 20:30:00', CAST(85.00 AS Decimal(6, 2)), N'Fun', 3, 2500, 2)
INSERT INTO [dbo].[Performances] ([Id], [EventDateTime], [Price], [Description], [VenueId], [SeatsRemaining], [PerformerId]) VALUES (8, N'2018-07-20 20:00:00', CAST(89.00 AS Decimal(6, 2)), N'Fun', 4, 1500, 3)
SET IDENTITY_INSERT [dbo].[Performances] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
