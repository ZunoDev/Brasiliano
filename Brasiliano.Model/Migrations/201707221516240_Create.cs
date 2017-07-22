namespace Brasiliano.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cidade", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Estado", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Estado", "Name", c => c.String());
            AlterColumn("dbo.Cidade", "Name", c => c.String());
        }
    }
}
