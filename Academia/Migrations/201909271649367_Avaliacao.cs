namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Avaliacao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TAB_AVALIACAO",
                c => new
                    {
                        idAvaliacao = c.Int(nullable: false, identity: true),
                        criadoEm = c.DateTime(nullable: false),
                        dataMarcada = c.DateTime(nullable: false),
                        aluno_idAluno = c.Int(),
                        professor_idProfessor = c.Int(),
                    })
                .PrimaryKey(t => t.idAvaliacao)
                .ForeignKey("dbo.TAB_ALUNO", t => t.aluno_idAluno)
                .ForeignKey("dbo.TAB_PROFESSOR", t => t.professor_idProfessor)
                .Index(t => t.aluno_idAluno)
                .Index(t => t.professor_idProfessor);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TAB_AVALIACAO", "professor_idProfessor", "dbo.TAB_PROFESSOR");
            DropForeignKey("dbo.TAB_AVALIACAO", "aluno_idAluno", "dbo.TAB_ALUNO");
            DropIndex("dbo.TAB_AVALIACAO", new[] { "professor_idProfessor" });
            DropIndex("dbo.TAB_AVALIACAO", new[] { "aluno_idAluno" });
            DropTable("dbo.TAB_AVALIACAO");
        }
    }
}
