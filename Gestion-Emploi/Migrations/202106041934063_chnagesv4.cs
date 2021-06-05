namespace GestionEmploi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chnagesv4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Niveaux", "Code", c => c.String(nullable: false));
            AlterColumn("dbo.Niveaux", "libelle", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Niveaux", "libelle", c => c.String());
            AlterColumn("dbo.Niveaux", "Code", c => c.String());
        }
    }
}
