namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class smalldatetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TAB_AVALIACAO", "dataMarcada", c => c.DateTime(storeType: "smalldatetime"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TAB_AVALIACAO", "dataMarcada", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
    }
}
