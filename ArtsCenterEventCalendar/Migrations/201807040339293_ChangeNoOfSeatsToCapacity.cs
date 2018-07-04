namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNoOfSeatsToCapacity : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Venues", "NumberOfSeats", "Capacity");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Venues", "Capacity", "NumberOfSeats");
        }
    }
}
