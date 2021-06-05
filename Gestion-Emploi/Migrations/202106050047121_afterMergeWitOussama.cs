namespace GestionEmploi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class afterMergeWitOussama : DbMigration
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
