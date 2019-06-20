namespace E_Commerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstcreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Address_City", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address_Country", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address_Street", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address_blockNum", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address_apartmentNum", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address_others", c => c.String());
            AddColumn("dbo.AspNetUsers", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Description");
            DropColumn("dbo.AspNetUsers", "Address_others");
            DropColumn("dbo.AspNetUsers", "Address_apartmentNum");
            DropColumn("dbo.AspNetUsers", "Address_blockNum");
            DropColumn("dbo.AspNetUsers", "Address_Street");
            DropColumn("dbo.AspNetUsers", "Address_Country");
            DropColumn("dbo.AspNetUsers", "Address_City");
        }
    }
}
