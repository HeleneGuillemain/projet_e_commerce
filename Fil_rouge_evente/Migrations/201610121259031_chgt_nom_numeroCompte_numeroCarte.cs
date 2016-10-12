namespace Fil_rouge_evente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chgt_nom_numeroCompte_numeroCarte : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MoyenPaiements", "NumeroCarte", c => c.String());
            DropColumn("dbo.MoyenPaiements", "NumeroCompte");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MoyenPaiements", "NumeroCompte", c => c.String());
            DropColumn("dbo.MoyenPaiements", "NumeroCarte");
        }
    }
}
