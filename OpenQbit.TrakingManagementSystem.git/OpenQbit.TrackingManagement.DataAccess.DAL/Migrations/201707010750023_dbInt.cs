namespace OpenQbit.TrackingManagement.DataAccess.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbInt : DbMigration
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
                        RootId = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TourID)
                .ForeignKey("dbo.Root", t => t.RootId, cascadeDelete: true)
                .Index(t => t.RootId);
            
            CreateTable(
                "dbo.Root",
                c => new
                    {
                        RootID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.RootID);
            
            CreateTable(
                "dbo.RootDetail",
                c => new
                    {
                        RootDetailID = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Time = c.DateTime(nullable: false),
                        RootID = c.String(),
                        Root_RootID = c.Int(),
                    })
                .PrimaryKey(t => t.RootDetailID)
                .ForeignKey("dbo.Root", t => t.Root_RootID)
                .Index(t => t.Root_RootID);
            
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        VehicleID = c.Int(nullable: false, identity: true),
                        VehicleType = c.String(),
                        VehicleNO = c.String(),
                        TourNO = c.Int(nullable: false),
                        ResourceId = c.Int(nullable: false),
                        Tour_TourID = c.Int(),
                    })
                .PrimaryKey(t => t.VehicleID)
                .ForeignKey("dbo.Resource", t => t.ResourceId, cascadeDelete: true)
                .ForeignKey("dbo.Tour", t => t.Tour_TourID)
                .Index(t => t.ResourceId)
                .Index(t => t.Tour_TourID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicle", "Tour_TourID", "dbo.Tour");
            DropForeignKey("dbo.Vehicle", "ResourceId", "dbo.Resource");
            DropForeignKey("dbo.Tour", "RootId", "dbo.Root");
            DropForeignKey("dbo.RootDetail", "Root_RootID", "dbo.Root");
            DropForeignKey("dbo.Driver", "TourID", "dbo.Tour");
            DropForeignKey("dbo.Driver", "ResourceId", "dbo.Resource");
            DropIndex("dbo.Vehicle", new[] { "Tour_TourID" });
            DropIndex("dbo.Vehicle", new[] { "ResourceId" });
            DropIndex("dbo.RootDetail", new[] { "Root_RootID" });
            DropIndex("dbo.Tour", new[] { "RootId" });
            DropIndex("dbo.Driver", new[] { "ResourceId" });
            DropIndex("dbo.Driver", new[] { "TourID" });
            DropTable("dbo.Vehicle");
            DropTable("dbo.RootDetail");
            DropTable("dbo.Root");
            DropTable("dbo.Tour");
            DropTable("dbo.Resource");
            DropTable("dbo.Driver");
        }
    }
}
