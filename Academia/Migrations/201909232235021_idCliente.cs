namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idCliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TAB_IMC",
                c => new
                    {
                        idImc = c.Int(nullable: false, identity: true),
                        idCliente = c.Int(nullable: false),
                        altura = c.Double(nullable: false),
                        peso = c.Double(nullable: false),
                        criadoEm = c.DateTime(nullable: false),
                        imcResult = c.String(),
                    })
                .PrimaryKey(t => t.idImc);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TAB_IMC");
        }
    }
}
