namespace FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _120619 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        MaxTickets = c.Int(nullable: false),
                        AvailableTickets = c.Int(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        EventType = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        OrganizerEmail = c.String(),
                        OrganizerPhone = c.String(),
                        VenueName = c.String(),
                        VenueCity = c.String(),
                        VenueState = c.String(),
                    })
                .PrimaryKey(t => t.EventID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
