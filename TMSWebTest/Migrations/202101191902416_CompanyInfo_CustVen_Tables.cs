namespace TMSWebTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyInfo_CustVen_Tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompanyInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        VAT_NIP = c.String(),
                        Phone = c.String(),
                        Mobile = c.String(),
                        Address = c.String(),
                        Website = c.String(),
                        Email = c.String(),
                        Branch = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        AccountId = c.Int(nullable: false),
                        Notes = c.String(),
                        Logo = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerAndVendor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        AccountId = c.Int(nullable: false),
                        IsCustomer = c.Boolean(nullable: false),
                        VAT_NIP = c.String(),
                        Mobile = c.String(),
                        Address = c.String(),
                        Website = c.String(),
                        Email = c.String(),
                        Branch = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        Notes = c.String(),
                        MaxCredit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            Sql(@"
USE [AMS]
GO
IF NOT EXISTS (SELECT 1 FROM CompanyInfo Where id = 1)
BEGIN
INSERT INTO [dbo].[CompanyInfo]
           ([Name]
           ,[AccountId]
           ,[Notes]
)
     VALUES
           ('Company NamePlace Holder',1,'Place Holder')
End

            ");
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerAndVendor");
            DropTable("dbo.CompanyInfo");
        }
    }
}
