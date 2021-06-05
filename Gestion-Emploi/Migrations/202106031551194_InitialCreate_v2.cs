namespace GestionEmploi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate_v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupId = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.GroupId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Groups");
        }
    }
}
