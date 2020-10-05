namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SemDataNascimento : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TAB_ALUNO", "dataNascimento");
            DropColumn("dbo.TAB_PROFESSOR", "dataNascimento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TAB_PROFESSOR", "dataNascimento", c => c.DateTime(nullable: false));
            AddColumn("dbo.TAB_ALUNO", "dataNascimento", c => c.DateTime(nullable: false));
        }
    }
}
