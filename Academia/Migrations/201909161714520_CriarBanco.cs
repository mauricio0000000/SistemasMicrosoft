namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TAB_ALUNO",
                c => new
                    {
                        idAluno = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        email = c.String(),
                        cpf = c.String(),
                        rg = c.String(),
                        estado = c.String(),
                        cidade = c.String(),
                        bairro = c.String(),
                        dataNascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idAluno);
            
            CreateTable(
                "dbo.TAB_PROFESSOR",
                c => new
                    {
                        idProfessor = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        email = c.String(),
                        cpf = c.String(),
                        rg = c.String(),
                        estado = c.String(),
                        cidade = c.String(),
                        bairro = c.String(),
                        dataNascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idProfessor);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TAB_PROFESSOR");
            DropTable("dbo.TAB_ALUNO");
        }
    }
}
