namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imcAtualizado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TAB_IMC", "idAluno", c => c.Int(nullable: false));
            CreateIndex("dbo.TAB_IMC", "idAluno");
            AddForeignKey("dbo.TAB_IMC", "idAluno", "dbo.TAB_ALUNO", "idAluno", cascadeDelete: true);
            DropColumn("dbo.TAB_IMC", "idCliente");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TAB_IMC", "idCliente", c => c.Int(nullable: false));
            DropForeignKey("dbo.TAB_IMC", "idAluno", "dbo.TAB_ALUNO");
            DropIndex("dbo.TAB_IMC", new[] { "idAluno" });
            DropColumn("dbo.TAB_IMC", "idAluno");
        }
    }
}
