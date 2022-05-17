namespace Cotizador.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreacionDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Precio = c.Double(nullable: false),
                        Marca = c.String(),
                        NroPatente = c.String(),
                        Anio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Camioneta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Precio = c.Double(nullable: false),
                        Marca = c.String(),
                        NroPatente = c.String(),
                        Anio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Persona",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Domicilio = c.String(),
                        DNI = c.Int(nullable: false),
                        VehiculoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Persona");
            DropTable("dbo.Camioneta");
            DropTable("dbo.Auto");
        }
    }
}
