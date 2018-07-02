namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAddressesTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"
SET IDENTITY_INSERT [dbo].[Addresses] ON
INSERT INTO [dbo].[Addresses] ([Id], [StreetAddress], [City], [State], [ZipCode]) VALUES (1, N'1234 Breck Way', N'Golden', N'CO', N'80123')
INSERT INTO [dbo].[Addresses] ([Id], [StreetAddress], [City], [State], [ZipCode]) VALUES (2, N'567 Einstein Ct', N'Denver', N'CO', N'80554')
INSERT INTO [dbo].[Addresses] ([Id], [StreetAddress], [City], [State], [ZipCode]) VALUES (3, N'987 Wahoo Dr', N'Englewood', N'CO', N'80112')
INSERT INTO [dbo].[Addresses] ([Id], [StreetAddress], [City], [State], [ZipCode]) VALUES (4, N'321 Caboom St', N'Parker', N'CO', N'80013')
SET IDENTITY_INSERT [dbo].[Addresses] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
