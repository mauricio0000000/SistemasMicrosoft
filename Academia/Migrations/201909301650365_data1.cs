﻿namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TAB_AVALIACAO", "dataMarcada", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TAB_AVALIACAO", "dataMarcada", c => c.DateTime());
        }
    }
}
