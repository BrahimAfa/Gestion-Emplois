namespace GestionEmploi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locals", "Libelle", c => c.String(nullable: false));
            AlterColumn("dbo.Locals", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Locals", "Capacity", c => c.String(nullable: false));
            AlterColumn("dbo.Locals", "Localisation", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locals", "Localisation", c => c.String());
            AlterColumn("dbo.Locals", "Capacity", c => c.String());
            AlterColumn("dbo.Locals", "Type", c => c.String());
            AlterColumn("dbo.Locals", "Libelle", c => c.String());
        }
    }
}
