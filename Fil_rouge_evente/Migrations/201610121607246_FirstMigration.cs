namespace Fil_rouge_evente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Utilisateurs", "Nom", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Utilisateurs", "Prenom", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Utilisateurs", "Email", c => c.String(nullable: false, maxLength: 8000, unicode: false));
            AlterColumn("dbo.Utilisateurs", "Password", c => c.String(nullable: false, maxLength: 50, unicode: false));
            CreateIndex("dbo.Utilisateurs", "Email", unique: true, name: "EmailIndex");
            DropColumn("dbo.Utilisateurs", "confirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Utilisateurs", "confirmPassword", c => c.String(nullable: false));
            DropIndex("dbo.Utilisateurs", "EmailIndex");
            AlterColumn("dbo.Utilisateurs", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Utilisateurs", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Utilisateurs", "Prenom", c => c.String(nullable: false));
            AlterColumn("dbo.Utilisateurs", "Nom", c => c.String(nullable: false));
        }
    }
}
