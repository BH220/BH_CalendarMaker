namespace BH_CalendarMaker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class 널필드업데이트 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BHB_CategoryCode", "updateAt", c => c.DateTime());
            AlterColumn("dbo.BHB_CategoryCode", "deleteAt", c => c.DateTime());
            AlterColumn("dbo.BHB_Code", "updateAt", c => c.DateTime());
            AlterColumn("dbo.BHB_Code", "deleteAt", c => c.DateTime());
            AlterColumn("dbo.BHB_User", "updateAt", c => c.DateTime());
            AlterColumn("dbo.BHB_User", "deleteAt", c => c.DateTime());
            AlterColumn("dbo.BHR_Anniversary", "updateAt", c => c.DateTime());
            AlterColumn("dbo.BHR_Anniversary", "deleteAt", c => c.DateTime());
            AlterColumn("dbo.BHR_AnniversaryCalendar", "updateAt", c => c.DateTime());
            AlterColumn("dbo.BHR_AnniversaryCalendar", "deleteAt", c => c.DateTime());
            AlterColumn("dbo.BHR_Calendar", "updateAt", c => c.DateTime());
            AlterColumn("dbo.BHR_Calendar", "deleteAt", c => c.DateTime());
            AlterColumn("dbo.BHR_CalendarUser", "updateAt", c => c.DateTime());
            AlterColumn("dbo.BHR_CalendarUser", "deleteAt", c => c.DateTime());
            AlterColumn("dbo.BHS_Color", "updateAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BHS_Color", "updateAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BHR_CalendarUser", "deleteAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BHR_CalendarUser", "updateAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BHR_Calendar", "deleteAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BHR_Calendar", "updateAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BHR_AnniversaryCalendar", "deleteAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BHR_AnniversaryCalendar", "updateAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BHR_Anniversary", "deleteAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BHR_Anniversary", "updateAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BHB_User", "deleteAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BHB_User", "updateAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BHB_Code", "deleteAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BHB_Code", "updateAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BHB_CategoryCode", "deleteAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BHB_CategoryCode", "updateAt", c => c.DateTime(nullable: false));
        }
    }
}
