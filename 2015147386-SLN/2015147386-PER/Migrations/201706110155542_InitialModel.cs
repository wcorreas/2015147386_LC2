namespace _2015147386_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        BusId = c.Int(nullable: false, identity: true),
                        Placa = c.String(),
                    })
                .PrimaryKey(t => t.BusId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        EmpleadoId = c.Int(nullable: false, identity: true),
                        Classificaion = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.EmpleadoId);
            
            CreateTable(
                "dbo.LugarViajes",
                c => new
                    {
                        LugarViajeId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.LugarViajeId);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        ServicioId = c.Int(nullable: false, identity: true),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ServicioId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.VentaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ventas");
            DropTable("dbo.Servicios");
            DropTable("dbo.LugarViajes");
            DropTable("dbo.Empleados");
            DropTable("dbo.Clientes");
            DropTable("dbo.Buses");
        }
    }
}
