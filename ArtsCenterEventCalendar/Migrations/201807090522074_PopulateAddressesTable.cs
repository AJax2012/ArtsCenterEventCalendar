namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAddressesTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Addresses] ON
INSERT INTO [dbo].[Addresses] ([Id], [StreetAddress], [City], [State], [ZipCode], [IsActive]) VALUES (1, N'18300 W Alameda Pkwy', N'Morrison', N'CO', N'80123', 1)
INSERT INTO [dbo].[Addresses] ([Id], [StreetAddress], [City], [State], [ZipCode], [IsActive]) VALUES (2, N'567 Einstein Ct', N'Denver', N'CO', N'80554', 1)
INSERT INTO [dbo].[Addresses] ([Id], [StreetAddress], [City], [State], [ZipCode], [IsActive]) VALUES (3, N'548 WhoKnows Way', N'Englewood', N'CO', N'80112', 1)
INSERT INTO [dbo].[Addresses] ([Id], [StreetAddress], [City], [State], [ZipCode], [IsActive]) VALUES (4, N'321 Caboom St', N'Parker', N'CO', N'80013', 1)
INSERT INTO [dbo].[Addresses] ([Id], [StreetAddress], [City], [State], [ZipCode], [IsActive]) VALUES (5, N'3317 E Colfax Ave', N'Denver', N'CO', N'80206', 1)
SET IDENTITY_INSERT [dbo].[Addresses] OFF");
        }
        
        public override void Down()
        {
        }
    }
}
