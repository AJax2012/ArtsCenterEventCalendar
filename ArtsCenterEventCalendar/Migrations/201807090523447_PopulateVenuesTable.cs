namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVenuesTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Venues] ON
INSERT INTO [dbo].[Venues] ([Id], [Name], [Capacity], [AddressId], [IsActive]) VALUES (1, N'Red Rocks', 5600, 1, 1)
INSERT INTO [dbo].[Venues] ([Id], [Name], [Capacity], [AddressId], [IsActive]) VALUES (2, N'Pepsi Center', 2000, 2, 1)
INSERT INTO [dbo].[Venues] ([Id], [Name], [Capacity], [AddressId], [IsActive]) VALUES (3, N'Englewood PAC', 500, 3, 1)
INSERT INTO [dbo].[Venues] ([Id], [Name], [Capacity], [AddressId], [IsActive]) VALUES (4, N'PACE Center', 555, 4, 1)
INSERT INTO [dbo].[Venues] ([Id], [Name], [Capacity], [AddressId], [IsActive]) VALUES (5, N'Bluebird Theater', 550, 5, 1)
SET IDENTITY_INSERT [dbo].[Venues] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
