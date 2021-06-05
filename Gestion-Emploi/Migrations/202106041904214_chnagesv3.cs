namespace GestionEmploi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chnagesv3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cours", "Libelle", c => c.String(nullable: false));
            AlterColumn("dbo.Professors", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Professors", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Professors", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Professors", "Email", c => c.String());
            AlterColumn("dbo.Professors", "LastName", c => c.String());
            AlterColumn("dbo.Professors", "FirstName", c => c.String());
            AlterColumn("dbo.Cours", "Libelle", c => c.String());
        }
    }
}
