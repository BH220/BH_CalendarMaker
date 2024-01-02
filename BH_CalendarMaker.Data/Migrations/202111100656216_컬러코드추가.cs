namespace BH_CalendarMaker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class 컬러코드추가 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BHR_Anniversary", "hexColorCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BHR_Anniversary", "hexColorCode");
        }
    }
}
