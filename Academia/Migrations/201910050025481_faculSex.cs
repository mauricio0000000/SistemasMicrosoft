namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class faculSex : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TAB_IMC", "idAluno", "dbo.TAB_ALUNO");
            DropIndex("dbo.TAB_IMC", new[] { "idAluno" });
            AlterColumn("dbo.TAB_IMC", "idAluno", c => c.Int());
            CreateIndex("dbo.TAB_IMC", "idAluno");
            AddForeignKey("dbo.TAB_IMC", "idAluno", "dbo.TAB_ALUNO", "idAluno");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TAB_IMC", "idAluno", "dbo.TAB_ALUNO");
            DropIndex("dbo.TAB_IMC", new[] { "idAluno" });
            AlterColumn("dbo.TAB_IMC", "idAluno", c => c.Int(nullable: false));
            CreateIndex("dbo.TAB_IMC", "idAluno");
            AddForeignKey("dbo.TAB_IMC", "idAluno", "dbo.TAB_ALUNO", "idAluno", cascadeDelete: true);
        }
    }
}
