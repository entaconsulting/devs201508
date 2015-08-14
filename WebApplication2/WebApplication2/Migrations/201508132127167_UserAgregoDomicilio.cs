namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAgregoDomicilio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Domicilio", c => c.String());
            AddColumn("dbo.AspNetUsers", "Domicilio2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Domicilio2");
            DropColumn("dbo.AspNetUsers", "Domicilio");
        }
    }
}
