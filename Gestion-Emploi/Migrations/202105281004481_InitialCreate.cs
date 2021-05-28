namespace GestionEmploi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Semaines", "libelle", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Semaines", "libelle", c => c.String());
        }
    }
}
