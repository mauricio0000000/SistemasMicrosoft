namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resultadoImc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TAB_IMC", "resultado", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TAB_IMC", "resultado");
        }
    }
}
