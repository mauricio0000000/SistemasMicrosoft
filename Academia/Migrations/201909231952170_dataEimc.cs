namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataEimc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TAB_ALUNO", "criadoEm", c => c.DateTime(nullable: false));
            AddColumn("dbo.TAB_PROFESSOR", "criadoEm", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TAB_PROFESSOR", "criadoEm");
            DropColumn("dbo.TAB_ALUNO", "criadoEm");
        }
    }
}
