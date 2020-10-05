namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class senha : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TAB_ALUNO", "senha", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TAB_ALUNO", "senha");
        }
    }
}
