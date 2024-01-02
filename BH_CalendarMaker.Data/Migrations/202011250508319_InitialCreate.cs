namespace BH_CalendarMaker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BHB_CategoryCode",
                c => new
                    {
                        seq = c.Int(nullable: false, identity: true),
                        code = c.Int(nullable: false),
                        name = c.String(),
                        note = c.String(),
                        enable = c.Int(nullable: false),
                        createBy = c.String(),
                        createAt = c.DateTime(nullable: false),
                        updateBy = c.String(),
                        updateAt = c.DateTime(nullable: false),
                        deleteBy = c.String(),
                        deleteAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.seq);
            
            CreateTable(
                "dbo.BHB_Code",
                c => new
                    {
                        seq = c.Int(nullable: false, identity: true),
                        categoryCode = c.Int(nullable: false),
                        code = c.Int(nullable: false),
                        name = c.String(),
                        note = c.String(),
                        enable = c.Int(nullable: false),
                        createBy = c.String(),
                        createAt = c.DateTime(nullable: false),
                        updateBy = c.String(),
                        updateAt = c.DateTime(nullable: false),
                        deleteBy = c.String(),
                        deleteAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.seq);
            
            CreateTable(
                "dbo.BHB_User",
                c => new
                    {
                        seq = c.Int(nullable: false, identity: true),
                        id = c.String(),
                        pw = c.String(),
                        name = c.String(),
                        contact = c.String(),
                        note = c.String(),
                        enable = c.Int(nullable: false),
                        createBy = c.String(),
                        createAt = c.DateTime(nullable: false),
                        updateBy = c.String(),
                        updateAt = c.DateTime(nullable: false),
                        deleteBy = c.String(),
                        deleteAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.seq);
            
            CreateTable(
                "dbo.BHR_Anniversary",
                c => new
                    {
                        seq = c.Int(nullable: false, identity: true),
                        id = c.Int(nullable: false),
                        name = c.String(),
                        date = c.String(),
                        repeatType = c.Int(nullable: false),
                        contents = c.String(),
                        category = c.Int(nullable: false),
                        dateType = c.Int(nullable: false),
                        enable = c.Int(nullable: false),
                        createBy = c.String(),
                        createAt = c.DateTime(nullable: false),
                        updateBy = c.String(),
                        updateAt = c.DateTime(nullable: false),
                        deleteBy = c.String(),
                        deleteAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.seq);
            
            CreateTable(
                "dbo.BHR_AnniversaryCalendar",
                c => new
                    {
                        seq = c.Int(nullable: false, identity: true),
                        calendarId = c.Int(nullable: false),
                        anniversaryId = c.Int(nullable: false),
                        enable = c.Int(nullable: false),
                        createBy = c.String(),
                        createAt = c.DateTime(nullable: false),
                        updateBy = c.String(),
                        updateAt = c.DateTime(nullable: false),
                        deleteBy = c.String(),
                        deleteAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.seq);
            
            CreateTable(
                "dbo.BHR_Calendar",
                c => new
                    {
                        seq = c.Int(nullable: false, identity: true),
                        id = c.Int(nullable: false),
                        name = c.String(),
                        note = c.String(),
                        enable = c.Int(nullable: false),
                        createBy = c.String(),
                        createAt = c.DateTime(nullable: false),
                        updateBy = c.String(),
                        updateAt = c.DateTime(nullable: false),
                        deleteBy = c.String(),
                        deleteAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.seq);
            
            CreateTable(
                "dbo.BHR_CalendarUser",
                c => new
                    {
                        seq = c.Int(nullable: false, identity: true),
                        calendarId = c.Int(nullable: false),
                        userId = c.String(),
                        note = c.String(),
                        enable = c.Int(nullable: false),
                        createBy = c.String(),
                        createAt = c.DateTime(nullable: false),
                        updateBy = c.String(),
                        updateAt = c.DateTime(nullable: false),
                        deleteBy = c.String(),
                        deleteAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.seq);
            
            CreateTable(
                "dbo.BHS_Color",
                c => new
                    {
                        seq = c.Int(nullable: false, identity: true),
                        category = c.Int(nullable: false),
                        color = c.String(),
                        createBy = c.String(),
                        createAt = c.DateTime(nullable: false),
                        updateBy = c.String(),
                        updateAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.seq);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BHS_Color");
            DropTable("dbo.BHR_CalendarUser");
            DropTable("dbo.BHR_Calendar");
            DropTable("dbo.BHR_AnniversaryCalendar");
            DropTable("dbo.BHR_Anniversary");
            DropTable("dbo.BHB_User");
            DropTable("dbo.BHB_Code");
            DropTable("dbo.BHB_CategoryCode");
        }
    }
}
