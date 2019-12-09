namespace FInalProject2.Migrations
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
                        EventName = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 150),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        OrganizerName = c.String(nullable: false),
                        OrganizerEmail = c.String(),
                        OrganizerPhone = c.String(),
                        VenueName = c.String(nullable: false),
                        VenueCity = c.String(),
                        VenueState = c.String(),
                        MaxTickets = c.Int(nullable: false),
                        AvailableTickets = c.Int(nullable: false),
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
                        RecordID = c.Int(nullable: false, identity: true),
                        CartID = c.String(),
                        EventID = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID)
                .ForeignKey("dbo.Events", t => t.EventID, cascadeDelete: true)
                .Index(t => t.EventID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "EventID", "dbo.Events");
            DropForeignKey("dbo.Events", "Type_TypeID", "dbo.EventTypes");
            DropIndex("dbo.Orders", new[] { "EventID" });
            DropIndex("dbo.Events", new[] { "Type_TypeID" });
            DropTable("dbo.Orders");
            DropTable("dbo.EventTypes");
            DropTable("dbo.Events");
        }
    }
}
