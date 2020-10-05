namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class login : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TAB_PROFESSOR", "senha", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TAB_PROFESSOR", "senha");
        }
    }
}
