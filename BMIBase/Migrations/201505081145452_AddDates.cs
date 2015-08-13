namespace BMIBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BodyComposition", "CreatedDate", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
			AddColumn("dbo.BodyComposition", "ModifiedDate", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
            AddColumn("dbo.BodyComposition", "MeasuredDate", c => c.DateTime(nullable: false));
			AddColumn("dbo.UserData", "CreatedDate", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
			AddColumn("dbo.UserData", "ModifiedDate", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
			Sql("UPDATE [dbo].[BodyComposition] SET [Userid] = '0'");
            AlterColumn("dbo.BodyComposition", "Userid", c => c.String(nullable: false));
			AlterColumn("dbo.UserData", "UserId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserData", "UserId", c => c.String());
            AlterColumn("dbo.BodyComposition", "Userid", c => c.String());
            DropColumn("dbo.UserData", "ModifiedDate");
            DropColumn("dbo.UserData", "CreatedDate");
            DropColumn("dbo.BodyComposition", "MeasuredDate");
            DropColumn("dbo.BodyComposition", "ModifiedDate");
            DropColumn("dbo.BodyComposition", "CreatedDate");
        }
    }
}
