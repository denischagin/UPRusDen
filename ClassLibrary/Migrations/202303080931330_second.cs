namespace ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Specials", "Code", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Specials", "Code");
        }
    }
}
