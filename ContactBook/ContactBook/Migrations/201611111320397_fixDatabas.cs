namespace ContactBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixDatabas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdressTypes", "AdressTypeName", c => c.String());
            AlterColumn("dbo.Contacts", "ContactName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "ContactName", c => c.Int(nullable: false));
            AlterColumn("dbo.AdressTypes", "AdressTypeName", c => c.Int(nullable: false));
        }
    }
}
