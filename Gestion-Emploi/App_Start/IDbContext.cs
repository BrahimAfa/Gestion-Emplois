using GestionEmploi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploi.App_Start
{
  public interface IDbContext
  {
    DbSet<Annee> Annees { get; set; }
    DbSet<Cour> Cours { get; set; }
    DbSet<DetailEmplois> DetailEmplois { get; set; }
    DbSet<Emplois> Emplois { get; set; }
    DbSet<Filiere> Filieres { get; set; }
    DbSet<Local> Locals { get; set; }
    DbSet<Niveau> Niveaux { get; set; }
    DbSet<Professor> Professors { get; set; }
    DbSet<Seance> Seances { get; set; }
    DbSet<Semaine> Semaines { get; set; }
    int SaveChanges();
    DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;


  }
}
