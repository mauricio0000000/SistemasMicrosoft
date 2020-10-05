namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreingKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TAB_AVALIACAO", "aluno_idAluno", "dbo.TAB_ALUNO");
            DropForeignKey("dbo.TAB_AVALIACAO", "professor_idProfessor", "dbo.TAB_PROFESSOR");
            DropIndex("dbo.TAB_AVALIACAO", new[] { "aluno_idAluno" });
            DropIndex("dbo.TAB_AVALIACAO", new[] { "professor_idProfessor" });
            RenameColumn(table: "dbo.TAB_AVALIACAO", name: "aluno_idAluno", newName: "idAluno");
            RenameColumn(table: "dbo.TAB_AVALIACAO", name: "professor_idProfessor", newName: "idProfessor");
            AlterColumn("dbo.TAB_AVALIACAO", "idAluno", c => c.Int(nullable: false));
            AlterColumn("dbo.TAB_AVALIACAO", "idProfessor", c => c.Int(nullable: false));
            CreateIndex("dbo.TAB_AVALIACAO", "idAluno");
            CreateIndex("dbo.TAB_AVALIACAO", "idProfessor");
            AddForeignKey("dbo.TAB_AVALIACAO", "idAluno", "dbo.TAB_ALUNO", "idAluno", cascadeDelete: true);
            AddForeignKey("dbo.TAB_AVALIACAO", "idProfessor", "dbo.TAB_PROFESSOR", "idProfessor", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TAB_AVALIACAO", "idProfessor", "dbo.TAB_PROFESSOR");
            DropForeignKey("dbo.TAB_AVALIACAO", "idAluno", "dbo.TAB_ALUNO");
            DropIndex("dbo.TAB_AVALIACAO", new[] { "idProfessor" });
            DropIndex("dbo.TAB_AVALIACAO", new[] { "idAluno" });
            AlterColumn("dbo.TAB_AVALIACAO", "idProfessor", c => c.Int());
            AlterColumn("dbo.TAB_AVALIACAO", "idAluno", c => c.Int());
            RenameColumn(table: "dbo.TAB_AVALIACAO", name: "idProfessor", newName: "professor_idProfessor");
            RenameColumn(table: "dbo.TAB_AVALIACAO", name: "idAluno", newName: "aluno_idAluno");
            CreateIndex("dbo.TAB_AVALIACAO", "professor_idProfessor");
            CreateIndex("dbo.TAB_AVALIACAO", "aluno_idAluno");
            AddForeignKey("dbo.TAB_AVALIACAO", "professor_idProfessor", "dbo.TAB_PROFESSOR", "idProfessor");
            AddForeignKey("dbo.TAB_AVALIACAO", "aluno_idAluno", "dbo.TAB_ALUNO", "idAluno");
        }
    }
}
