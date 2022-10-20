namespace EF2CapasApiFluent.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class messi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        DNI = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.Factura",
                c => new
                    {
                        IdFactura = c.Int(nullable: false, identity: true),
                        IdCliente = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false, storeType: "date"),
                        IVA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cliente_IdCliente = c.Int(),
                    })
                .PrimaryKey(t => t.IdFactura)
                .ForeignKey("dbo.Cliente", t => t.IdCliente, cascadeDelete: true)
                .ForeignKey("dbo.Cliente", t => t.Cliente_IdCliente)
                .Index(t => t.IdCliente)
                .Index(t => t.Cliente_IdCliente);
            
            CreateTable(
                "dbo.Detalle",
                c => new
                    {
                        IdDetalle = c.Int(nullable: false, identity: true),
                        IdFactura = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, storeType: "money"),
                        Cantidad = c.Int(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 200),
                        Factura_IdFactura = c.Int(),
                    })
                .PrimaryKey(t => t.IdDetalle)
                .ForeignKey("dbo.Factura", t => t.IdFactura, cascadeDelete: true)
                .ForeignKey("dbo.Factura", t => t.Factura_IdFactura)
                .Index(t => t.IdFactura)
                .Index(t => t.Factura_IdFactura);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Factura", "Cliente_IdCliente", "dbo.Cliente");
            DropForeignKey("dbo.Detalle", "Factura_IdFactura", "dbo.Factura");
            DropForeignKey("dbo.Detalle", "IdFactura", "dbo.Factura");
            DropForeignKey("dbo.Factura", "IdCliente", "dbo.Cliente");
            DropIndex("dbo.Detalle", new[] { "Factura_IdFactura" });
            DropIndex("dbo.Detalle", new[] { "IdFactura" });
            DropIndex("dbo.Factura", new[] { "Cliente_IdCliente" });
            DropIndex("dbo.Factura", new[] { "IdCliente" });
            DropTable("dbo.Detalle");
            DropTable("dbo.Factura");
            DropTable("dbo.Cliente");
        }
    }
}
