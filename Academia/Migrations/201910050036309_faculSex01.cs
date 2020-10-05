namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class faculSex01 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TAB_AVALIACAO", name: "idAluno", newName: "aluno_idAluno");
            RenameColumn(table: "dbo.TAB_AVALIACAO", name: "idProfessor", newName: "professor_idProfessor");
            RenameColumn(table: "dbo.TAB_IMC", name: "idAluno", newName: "aluno_idAluno");
            RenameIndex(table: "dbo.TAB_AVALIACAO", name: "IX_idAluno", newName: "IX_aluno_idAluno");
            RenameIndex(table: "dbo.TAB_AVALIACAO", name: "IX_idProfessor", newName: "IX_professor_idProfessor");
            RenameIndex(table: "dbo.TAB_IMC", name: "IX_idAluno", newName: "IX_aluno_idAluno");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.TAB_IMC", name: "IX_aluno_idAluno", newName: "IX_idAluno");
            RenameIndex(table: "dbo.TAB_AVALIACAO", name: "IX_professor_idProfessor", newName: "IX_idProfessor");
            RenameIndex(table: "dbo.TAB_AVALIACAO", name: "IX_aluno_idAluno", newName: "IX_idAluno");
            RenameColumn(table: "dbo.TAB_IMC", name: "aluno_idAluno", newName: "idAluno");
            RenameColumn(table: "dbo.TAB_AVALIACAO", name: "professor_idProfessor", newName: "idProfessor");
            RenameColumn(table: "dbo.TAB_AVALIACAO", name: "aluno_idAluno", newName: "idAluno");
        }
    }
}
