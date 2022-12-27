namespace SalesManagement_SysDev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.T_Chumon", "EmID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.T_Chumon", "EmID", c => c.Int(nullable: false));
        }
    }
}
