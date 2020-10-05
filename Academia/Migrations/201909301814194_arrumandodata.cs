namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class arrumandodata : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TAB_AVALIACAO", "dataMarcada", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TAB_AVALIACAO", "dataMarcada", c => c.DateTime(storeType: "smalldatetime"));
        }
    }
}
