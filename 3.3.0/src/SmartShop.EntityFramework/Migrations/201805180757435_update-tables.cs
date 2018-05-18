namespace SmartShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetables : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Areas", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.ShopProductClasses", "ClassName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.ShopProductClasses", "Description", c => c.String(nullable: false, maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ShopProductClasses", "Description", c => c.String());
            AlterColumn("dbo.ShopProductClasses", "ClassName", c => c.String());
            AlterColumn("dbo.Areas", "Name", c => c.String());
        }
    }
}
