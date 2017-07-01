namespace OpenQbit.TrackingManagement.DataAccess.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setDb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vehicle", "Tour_TourID", "dbo.Tour");
            DropIndex("dbo.Vehicle", new[] { "Tour_TourID" });
            RenameColumn(table: "dbo.Vehicle", name: "Tour_TourID", newName: "TourID");
            AlterColumn("dbo.Vehicle", "TourID", c => c.Int(nullable: false));
            CreateIndex("dbo.Vehicle", "TourID");
            AddForeignKey("dbo.Vehicle", "TourID", "dbo.Tour", "TourID", cascadeDelete: true);
            DropColumn("dbo.Vehicle", "TourNO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicle", "TourNO", c => c.Int(nullable: false));
            DropForeignKey("dbo.Vehicle", "TourID", "dbo.Tour");
            DropIndex("dbo.Vehicle", new[] { "TourID" });
            AlterColumn("dbo.Vehicle", "TourID", c => c.Int());
            RenameColumn(table: "dbo.Vehicle", name: "TourID", newName: "Tour_TourID");
            CreateIndex("dbo.Vehicle", "Tour_TourID");
            AddForeignKey("dbo.Vehicle", "Tour_TourID", "dbo.Tour", "TourID");
        }
    }
}
