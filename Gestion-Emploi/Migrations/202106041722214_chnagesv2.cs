namespace GestionEmploi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chnagesv2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Filieres", "Libelle", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Filieres", "Libelle", c => c.String());
        }
    }
}
