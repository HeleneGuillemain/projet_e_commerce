namespace Fil_rouge_evente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajout_heritage_moyenPaiement : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MoyenPaiements", "NomProprietaire", c => c.String());
            AddColumn("dbo.MoyenPaiements", "NumeroCompte", c => c.String());
            AddColumn("dbo.MoyenPaiements", "DateExpiration", c => c.DateTime());
            AddColumn("dbo.MoyenPaiements", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.MoyenPaiements", "typePaiement");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MoyenPaiements", "typePaiement", c => c.Int(nullable: false));
            DropColumn("dbo.MoyenPaiements", "Discriminator");
            DropColumn("dbo.MoyenPaiements", "DateExpiration");
            DropColumn("dbo.MoyenPaiements", "NumeroCompte");
            DropColumn("dbo.MoyenPaiements", "NomProprietaire");
        }
    }
}
