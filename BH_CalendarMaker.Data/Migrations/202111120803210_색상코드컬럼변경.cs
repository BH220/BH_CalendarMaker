namespace BH_CalendarMaker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class 색상코드컬럼변경 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BHR_Anniversary", "hexDayColorCode", c => c.String());
            AddColumn("dbo.BHR_Anniversary", "hexContentColorCode", c => c.String());
            DropColumn("dbo.BHR_Anniversary", "hexColorCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BHR_Anniversary", "hexColorCode", c => c.String());
            DropColumn("dbo.BHR_Anniversary", "hexContentColorCode");
            DropColumn("dbo.BHR_Anniversary", "hexDayColorCode");
        }
    }
}
