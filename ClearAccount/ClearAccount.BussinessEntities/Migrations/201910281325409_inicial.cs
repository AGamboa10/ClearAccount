namespace ClearAccount.BussinessEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "nombre", c => c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"));
            AlterColumn("dbo.Cliente", "telefono", c => c.String(maxLength: 18, unicode: false, storeType: "nvarchar"));
            AlterColumn("dbo.Cliente", "correo", c => c.String(maxLength: 30, unicode: false, storeType: "nvarchar"));
            AlterColumn("dbo.Cliente", "direccion", c => c.String(maxLength: 40, unicode: false, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "direccion", c => c.String(unicode: false));
            AlterColumn("dbo.Cliente", "correo", c => c.String(unicode: false));
            AlterColumn("dbo.Cliente", "telefono", c => c.String(unicode: false));
            AlterColumn("dbo.Cliente", "nombre", c => c.String(nullable: false, unicode: false));
        }
    }
}
