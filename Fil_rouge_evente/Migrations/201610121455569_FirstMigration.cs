namespace Fil_rouge_evente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Utilisateurs", "login");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Utilisateurs", "login", c => c.String(nullable: false));
        }
    }
}
