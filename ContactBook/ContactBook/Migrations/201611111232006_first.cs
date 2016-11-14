namespace ContactBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdressTypes",
                c => new
                    {
                        AdressTypeID = c.Int(nullable: false, identity: true),
                        AdressTypeName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AdressTypeID);
            
            CreateTable(
                "dbo.ContactAdresses",
                c => new
                    {
                        ContactAdressID = c.Int(nullable: false, identity: true),
                        ContactID = c.Int(nullable: false),
                        AdressTypeID = c.Int(nullable: false),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.ContactAdressID)
                .ForeignKey("dbo.AdressTypes", t => t.AdressTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Contacts", t => t.ContactID, cascadeDelete: true)
                .Index(t => t.ContactID)
                .Index(t => t.AdressTypeID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        ContactName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.ContactTelephoneNumbers",
                c => new
                    {
                        ContactTelephoneNumberID = c.Int(nullable: false, identity: true),
                        ContactID = c.Int(nullable: false),
                        TelephoneTypeID = c.Int(nullable: false),
                        TelefonNumber = c.String(),
                    })
                .PrimaryKey(t => t.ContactTelephoneNumberID)
                .ForeignKey("dbo.Contacts", t => t.ContactID, cascadeDelete: true)
                .ForeignKey("dbo.TelephoneTypes", t => t.TelephoneTypeID, cascadeDelete: true)
                .Index(t => t.ContactID)
                .Index(t => t.TelephoneTypeID);
            
            CreateTable(
                "dbo.TelephoneTypes",
                c => new
                    {
                        TelephoneTypeID = c.Int(nullable: false, identity: true),
                        TelephoneTypeName = c.String(),
                    })
                .PrimaryKey(t => t.TelephoneTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContactTelephoneNumbers", "TelephoneTypeID", "dbo.TelephoneTypes");
            DropForeignKey("dbo.ContactTelephoneNumbers", "ContactID", "dbo.Contacts");
            DropForeignKey("dbo.ContactAdresses", "ContactID", "dbo.Contacts");
            DropForeignKey("dbo.ContactAdresses", "AdressTypeID", "dbo.AdressTypes");
            DropIndex("dbo.ContactTelephoneNumbers", new[] { "TelephoneTypeID" });
            DropIndex("dbo.ContactTelephoneNumbers", new[] { "ContactID" });
            DropIndex("dbo.ContactAdresses", new[] { "AdressTypeID" });
            DropIndex("dbo.ContactAdresses", new[] { "ContactID" });
            DropTable("dbo.TelephoneTypes");
            DropTable("dbo.ContactTelephoneNumbers");
            DropTable("dbo.Contacts");
            DropTable("dbo.ContactAdresses");
            DropTable("dbo.AdressTypes");
        }
    }
}
