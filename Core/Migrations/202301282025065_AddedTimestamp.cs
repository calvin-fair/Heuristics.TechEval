namespace Heuristics.TechEval.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTimestamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Member", "LastUpdated", c => c.DateTime(nullable: false, defaultValueSql: "getdate()"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Member", "LastUpdated");
        }
    }
}
