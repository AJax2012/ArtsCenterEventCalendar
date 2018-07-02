namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVenuesTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"
SET IDENTITY_INSERT [dbo].[Venues] ON
INSERT INTO [dbo].[Venues] ([Id], [Name], [NumberOfSeats], [AddressId]) VALUES (1, N'Red Rocks', 5000, 1)
INSERT INTO [dbo].[Venues] ([Id], [Name], [NumberOfSeats], [AddressId]) VALUES (2, N'Pepsi Center', 2000, 2)
INSERT INTO [dbo].[Venues] ([Id], [Name], [NumberOfSeats], [AddressId]) VALUES (3, N'Englewood PAC', 1000, 3)
INSERT INTO [dbo].[Venues] ([Id], [Name], [NumberOfSeats], [AddressId]) VALUES (4, N'PACE Center', 555, 4)
SET IDENTITY_INSERT [dbo].[Venues] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
