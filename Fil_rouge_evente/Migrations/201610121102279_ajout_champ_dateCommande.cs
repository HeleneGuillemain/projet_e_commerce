namespace Fil_rouge_evente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajout_champ_dateCommande : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commandes", "DateCommande", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Commandes", "DateCommande");
        }
    }
}
