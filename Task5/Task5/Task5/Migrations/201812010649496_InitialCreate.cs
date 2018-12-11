namespace Task3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        DriverId = c.Int(nullable: false, identity: true),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 50),
                        Age = c.Int(nullable: false),
                        CarNumber = c.String(nullable: false),
                        Experience = c.Int(nullable: false),
                        CostPerMinute = c.Int(nullable: false),
                        PayCheck = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.DriverId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        ArriveTime = c.DateTime(nullable: false),
                        Dispatch = c.String(nullable: false, maxLength: 200),
                        Destination = c.String(nullable: false, maxLength: 200),
                        RoadTime = c.Int(nullable: false),
                        Cost = c.Int(nullable: false),
                        IsDone = c.Boolean(nullable: false),
                        Client_ClientId = c.Int(),
                        Driver_DriverId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId)
                .ForeignKey("dbo.Drivers", t => t.Driver_DriverId)
                .Index(t => t.Client_ClientId)
                .Index(t => t.Driver_DriverId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Driver_DriverId", "dbo.Drivers");
            DropForeignKey("dbo.Orders", "Client_ClientId", "dbo.Clients");
            DropIndex("dbo.Orders", new[] { "Driver_DriverId" });
            DropIndex("dbo.Orders", new[] { "Client_ClientId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Drivers");
            DropTable("dbo.Clients");
        }
    }
}
