namespace Fil_rouge_evente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajout_champ_actif_moyenPaiement : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MoyenPaiements", "Actif", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MoyenPaiements", "Actif");
        }
    }
}
