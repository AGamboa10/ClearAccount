namespace ClearAccount.BussinessEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        IdClient = c.Int(nullable: false),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.Client_Id)
                //.Index(t => t.Client_Id)
                ;
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        Apellido = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        Phone = c.String(maxLength: 20, unicode: false, storeType: "nvarchar"),
                        Mail = c.String(maxLength: 30, unicode: false, storeType: "nvarchar"),
                        Address = c.String(maxLength: 40, unicode: false, storeType: "nvarchar"),
                        IdImg = c.Int(nullable: false),
                        IdUser = c.Int(nullable: false),
                        Image_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Image", t => t.Image_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                //.Index(t => t.Image_Id)
                //.Index(t => t.User_Id)
                ;
            
            CreateTable(
                "dbo.Image",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageUrl = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Note",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Date = c.DateTime(nullable: false, precision: 0),
                        IdClient = c.Int(nullable: false),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.Client_Id)
                //.Index(t => t.Client_Id)
                ;
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameUser = c.String(nullable: false, unicode: false),
                        Password = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Client", "User_Id", "dbo.User");
            DropForeignKey("dbo.Note", "Client_Id", "dbo.Client");
            DropForeignKey("dbo.Client", "Image_Id", "dbo.Image");
            DropForeignKey("dbo.Account", "Client_Id", "dbo.Client");
            DropIndex("dbo.Client", new[] { "User_Id" });
            DropIndex("dbo.Note", new[] { "Client_Id" });
            DropIndex("dbo.Client", new[] { "Image_Id" });
            DropIndex("dbo.Account", new[] { "Client_Id" });
            DropTable("dbo.User");
            DropTable("dbo.Note");
            DropTable("dbo.Image");
            DropTable("dbo.Client");
            DropTable("dbo.Account");
        }
    }
}
