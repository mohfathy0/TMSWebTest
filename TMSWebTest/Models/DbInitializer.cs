using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using TMSWebTest.Migrations;

namespace TMSWebTest.Models
{
    public class DbInitializer : DbMigration
    {
       
        public override void Up()
        {

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
    }
}