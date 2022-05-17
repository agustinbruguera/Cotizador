namespace Cotizador.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBv2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Auto", "MarcaId", c => c.Int(nullable: false));
            AddColumn("dbo.Camioneta", "MarcaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Auto", "MarcaId");
            CreateIndex("dbo.Camioneta", "MarcaId");
            AddForeignKey("dbo.Auto", "MarcaId", "dbo.Marca", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Camioneta", "MarcaId", "dbo.Marca", "Id", cascadeDelete: true);
            DropColumn("dbo.Auto", "Marca");
            DropColumn("dbo.Camioneta", "Marca");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Camioneta", "Marca", c => c.String());
            AddColumn("dbo.Auto", "Marca", c => c.String());
            DropForeignKey("dbo.Camioneta", "MarcaId", "dbo.Marca");
            DropForeignKey("dbo.Auto", "MarcaId", "dbo.Marca");
            DropIndex("dbo.Camioneta", new[] { "MarcaId" });
            DropIndex("dbo.Auto", new[] { "MarcaId" });
            DropColumn("dbo.Camioneta", "MarcaId");
            DropColumn("dbo.Auto", "MarcaId");
            DropTable("dbo.Marca");
        }
    }
}
