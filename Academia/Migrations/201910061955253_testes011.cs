namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testes011 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TAB_AVALIACAO", "statusAvaliacao", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TAB_AVALIACAO", "statusAvaliacao");
        }
    }
}
