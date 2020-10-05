namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idProfAlunoNull : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TAB_AVALIACAO", "idAluno", "dbo.TAB_ALUNO");
            DropForeignKey("dbo.TAB_AVALIACAO", "idProfessor", "dbo.TAB_PROFESSOR");
            DropIndex("dbo.TAB_AVALIACAO", new[] { "idAluno" });
            DropIndex("dbo.TAB_AVALIACAO", new[] { "idProfessor" });
            AlterColumn("dbo.TAB_AVALIACAO", "idAluno", c => c.Int());
            AlterColumn("dbo.TAB_AVALIACAO", "idProfessor", c => c.Int());
            CreateIndex("dbo.TAB_AVALIACAO", "idAluno");
            CreateIndex("dbo.TAB_AVALIACAO", "idProfessor");
            AddForeignKey("dbo.TAB_AVALIACAO", "idAluno", "dbo.TAB_ALUNO", "idAluno");
            AddForeignKey("dbo.TAB_AVALIACAO", "idProfessor", "dbo.TAB_PROFESSOR", "idProfessor");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TAB_AVALIACAO", "idProfessor", "dbo.TAB_PROFESSOR");
            DropForeignKey("dbo.TAB_AVALIACAO", "idAluno", "dbo.TAB_ALUNO");
            DropIndex("dbo.TAB_AVALIACAO", new[] { "idProfessor" });
            DropIndex("dbo.TAB_AVALIACAO", new[] { "idAluno" });
            AlterColumn("dbo.TAB_AVALIACAO", "idProfessor", c => c.Int(nullable: false));
            AlterColumn("dbo.TAB_AVALIACAO", "idAluno", c => c.Int(nullable: false));
            CreateIndex("dbo.TAB_AVALIACAO", "idProfessor");
            CreateIndex("dbo.TAB_AVALIACAO", "idAluno");
            AddForeignKey("dbo.TAB_AVALIACAO", "idProfessor", "dbo.TAB_PROFESSOR", "idProfessor", cascadeDelete: true);
            AddForeignKey("dbo.TAB_AVALIACAO", "idAluno", "dbo.TAB_ALUNO", "idAluno", cascadeDelete: true);
        }
    }
}
