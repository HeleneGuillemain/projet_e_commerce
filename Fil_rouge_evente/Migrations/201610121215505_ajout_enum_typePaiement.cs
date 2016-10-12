namespace Fil_rouge_evente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajout_enum_typePaiement : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MoyenPaiements", "TypePaiement", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MoyenPaiements", "TypePaiement");
        }
    }
}
