namespace OpenQbit.TrakingManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Driver",
                c => new
                    {
                        DriverID = c.Int(nullable: false, identity: true),
                        DriverName = c.String(),
                        DriverNIC = c.Int(nullable: false),
                        TourID = c.Int(nullable: false),
                        ResourceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DriverID)
                .ForeignKey("dbo.Resource", t => t.ResourceId, cascadeDelete: true)
                .ForeignKey("dbo.Tour", t => t.TourID, cascadeDelete: true)
                .Index(t => t.TourID)
                .Index(t => t.ResourceId);
            
            CreateTable(
                "dbo.Resource",
                c => new
                    {
                        ResourceID = c.Int(nullable: false, identity: true),
                        UserID = c.String(),
                        GPSLocation = c.String(),
                    })
                .PrimaryKey(t => t.ResourceID);
            
            CreateTable(
                "dbo.Tour",
                c => new
                    {
                        TourID = c.Int(nullable: false, identity: true),
                        TourType = c.String(),
                        Location = c.String(),
                        RouteId = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TourID)
                .ForeignKey("dbo.Route", t => t.RouteId, cascadeDelete: true)
                .Index(t => t.RouteId);
            
            CreateTable(
                "dbo.Route",
                c => new
                    {
                        RouteID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.RouteID);
            
            CreateTable(
                "dbo.RouteDetail",
                c => new
                    {
                        RouteDetailID = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Time = c.DateTime(nullable: false),
                        RouteID = c.String(),
                        Route_RouteID = c.Int(),
                    })
                .PrimaryKey(t => t.RouteDetailID)
                .ForeignKey("dbo.Route", t => t.Route_RouteID)
                .Index(t => t.Route_RouteID);
            
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        VehicleID = c.Int(nullable: false, identity: true),
                        VehicleType = c.String(),
                        VehicleNO = c.String(),
                        TourID = c.Int(nullable: false),
                        ResourceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VehicleID)
                .ForeignKey("dbo.Resource", t => t.ResourceId, cascadeDelete: true)
                .ForeignKey("dbo.Tour", t => t.TourID, cascadeDelete: true)
                .Index(t => t.TourID)
                .Index(t => t.ResourceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicle", "TourID", "dbo.Tour");
            DropForeignKey("dbo.Vehicle", "ResourceId", "dbo.Resource");
            DropForeignKey("dbo.Tour", "RouteId", "dbo.Route");
            DropForeignKey("dbo.RouteDetail", "Route_RouteID", "dbo.Route");
            DropForeignKey("dbo.Driver", "TourID", "dbo.Tour");
            DropForeignKey("dbo.Driver", "ResourceId", "dbo.Resource");
            DropIndex("dbo.Vehicle", new[] { "ResourceId" });
            DropIndex("dbo.Vehicle", new[] { "TourID" });
            DropIndex("dbo.RouteDetail", new[] { "Route_RouteID" });
            DropIndex("dbo.Tour", new[] { "RouteId" });
            DropIndex("dbo.Driver", new[] { "ResourceId" });
            DropIndex("dbo.Driver", new[] { "TourID" });
            DropTable("dbo.Vehicle");
            DropTable("dbo.RouteDetail");
            DropTable("dbo.Route");
            DropTable("dbo.Tour");
            DropTable("dbo.Resource");
            DropTable("dbo.Driver");
        }
    }
}
