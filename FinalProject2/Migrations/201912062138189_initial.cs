namespace FinalProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
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
                        EventName = c.String(),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        OrganizerEmail = c.String(),
                        OrganizerPhone = c.String(),
                        VenueName = c.String(),
                        VenueCity = c.String(),
                        VenueState = c.String(),
                        Type_TypeID = c.Int(),
                    })
                .PrimaryKey(t => t.EventID)
                .ForeignKey("dbo.EventTypes", t => t.Type_TypeID)
                .Index(t => t.Type_TypeID);
            
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        TypeID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TypeID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        TicketCount = c.Int(nullable: false),
                        EventID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Type_TypeID", "dbo.EventTypes");
            DropIndex("dbo.Events", new[] { "Type_TypeID" });
            DropTable("dbo.Orders");
            DropTable("dbo.EventTypes");
            DropTable("dbo.Events");
        }
    }
}
