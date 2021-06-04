using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;

using GestionEmploi.Models;
using GestionEmploi.Utils;

namespace GestionEmploi.App_Start {
  public class GestionEmploisDbContext : DbContext,IDbContext
  {
    static Config config = FileUtils.LoadJson();
    public GestionEmploisDbContext():base(config.ConnectionString)
    {
    
    }

    public virtual DbSet<Annee> Annees { get ; set ; }
    public virtual DbSet<Cour> Cours { get ; set ; }
    public virtual DbSet<DetailEmplois> DetailEmplois { get ; set ; }
    public virtual DbSet<Emplois> Emplois { get ; set ; }
    public virtual DbSet<Filiere> Filieres { get ; set ; }
    public virtual DbSet<Local> Locals { get ; set ; }
    public virtual DbSet<Niveau> Niveaux { get ; set ; }
    public virtual DbSet<Professor> Professors { get ; set ; }
    public virtual DbSet<Seance> Seances { get ; set ; }
    public virtual DbSet<Semaine> Semaines { get ; set ; }
    public virtual DbSet<Group> Groupes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Emplois>()
        .HasRequired<Niveau>(p => p.Niveau)
        .WithMany()
        .WillCascadeOnDelete(false);
    }
  }
}