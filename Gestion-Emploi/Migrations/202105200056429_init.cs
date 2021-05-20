namespace GestionEmploi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Annees",
                c => new
                    {
                        AnneeId = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AnneeId);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        CourId = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                        ResponsableId = c.Int(nullable: false),
                        NiveauId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourId)
                .ForeignKey("dbo.Niveaux", t => t.NiveauId, cascadeDelete: true)
                .ForeignKey("dbo.Professors", t => t.ResponsableId, cascadeDelete: true)
                .Index(t => t.ResponsableId)
                .Index(t => t.NiveauId);
            
            CreateTable(
                "dbo.DetailEmplois",
                c => new
                    {
                        DetailEmploisId = c.Int(nullable: false, identity: true),
                        EmploisId = c.Int(nullable: false),
                        SeanceId = c.Int(nullable: false),
                        LocalId = c.Int(nullable: false),
                        CourId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DetailEmploisId)
                .ForeignKey("dbo.Cours", t => t.CourId, cascadeDelete: true)
                .ForeignKey("dbo.Emplois", t => t.EmploisId, cascadeDelete: true)
                .ForeignKey("dbo.Locals", t => t.LocalId, cascadeDelete: true)
                .ForeignKey("dbo.Seances", t => t.SeanceId, cascadeDelete: true)
                .Index(t => t.EmploisId)
                .Index(t => t.SeanceId)
                .Index(t => t.LocalId)
                .Index(t => t.CourId);
            
            CreateTable(
                "dbo.Emplois",
                c => new
                    {
                        EmploisId = c.Int(nullable: false, identity: true),
                        NiveauId = c.Int(nullable: false),
                        AnneeId = c.Int(nullable: false),
                        SemaineId = c.Int(nullable: false),
                        Niveau_NiveauId = c.Int(),
                    })
                .PrimaryKey(t => t.EmploisId)
                .ForeignKey("dbo.Annees", t => t.AnneeId, cascadeDelete: true)
                .ForeignKey("dbo.Niveaux", t => t.Niveau_NiveauId)
                .ForeignKey("dbo.Niveaux", t => t.NiveauId)
                .ForeignKey("dbo.Semaines", t => t.SemaineId, cascadeDelete: true)
                .Index(t => t.NiveauId)
                .Index(t => t.AnneeId)
                .Index(t => t.SemaineId)
                .Index(t => t.Niveau_NiveauId);
            
            CreateTable(
                "dbo.Niveaux",
                c => new
                    {
                        NiveauId = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        libelle = c.String(),
                        FiliereId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NiveauId)
                .ForeignKey("dbo.Filieres", t => t.FiliereId, cascadeDelete: true)
                .Index(t => t.FiliereId);
            
            CreateTable(
                "dbo.Filieres",
                c => new
                    {
                        FiliereId = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.FiliereId);
            
            CreateTable(
                "dbo.Semaines",
                c => new
                    {
                        SemaineId = c.Int(nullable: false, identity: true),
                        libelle = c.String(),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SemaineId);
            
            CreateTable(
                "dbo.Locals",
                c => new
                    {
                        LocalId = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                        Type = c.String(),
                        Capacity = c.String(),
                        Localisation = c.String(),
                    })
                .PrimaryKey(t => t.LocalId);
            
            CreateTable(
                "dbo.Seances",
                c => new
                    {
                        SeanceId = c.Int(nullable: false, identity: true),
                        HeurDebut = c.String(),
                        HeurFin = c.String(),
                        Jour = c.String(),
                    })
                .PrimaryKey(t => t.SeanceId);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        ProfessorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ProfessorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cours", "ResponsableId", "dbo.Professors");
            DropForeignKey("dbo.Cours", "NiveauId", "dbo.Niveaux");
            DropForeignKey("dbo.DetailEmplois", "SeanceId", "dbo.Seances");
            DropForeignKey("dbo.DetailEmplois", "LocalId", "dbo.Locals");
            DropForeignKey("dbo.DetailEmplois", "EmploisId", "dbo.Emplois");
            DropForeignKey("dbo.Emplois", "SemaineId", "dbo.Semaines");
            DropForeignKey("dbo.Emplois", "NiveauId", "dbo.Niveaux");
            DropForeignKey("dbo.Niveaux", "FiliereId", "dbo.Filieres");
            DropForeignKey("dbo.Emplois", "Niveau_NiveauId", "dbo.Niveaux");
            DropForeignKey("dbo.Emplois", "AnneeId", "dbo.Annees");
            DropForeignKey("dbo.DetailEmplois", "CourId", "dbo.Cours");
            DropIndex("dbo.Niveaux", new[] { "FiliereId" });
            DropIndex("dbo.Emplois", new[] { "Niveau_NiveauId" });
            DropIndex("dbo.Emplois", new[] { "SemaineId" });
            DropIndex("dbo.Emplois", new[] { "AnneeId" });
            DropIndex("dbo.Emplois", new[] { "NiveauId" });
            DropIndex("dbo.DetailEmplois", new[] { "CourId" });
            DropIndex("dbo.DetailEmplois", new[] { "LocalId" });
            DropIndex("dbo.DetailEmplois", new[] { "SeanceId" });
            DropIndex("dbo.DetailEmplois", new[] { "EmploisId" });
            DropIndex("dbo.Cours", new[] { "NiveauId" });
            DropIndex("dbo.Cours", new[] { "ResponsableId" });
            DropTable("dbo.Professors");
            DropTable("dbo.Seances");
            DropTable("dbo.Locals");
            DropTable("dbo.Semaines");
            DropTable("dbo.Filieres");
            DropTable("dbo.Niveaux");
            DropTable("dbo.Emplois");
            DropTable("dbo.DetailEmplois");
            DropTable("dbo.Cours");
            DropTable("dbo.Annees");
        }
    }
}
