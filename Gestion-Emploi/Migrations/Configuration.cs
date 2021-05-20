namespace GestionEmploi.Migrations
{
  using GestionEmploi.App_Start;
  using GestionEmploi.Models;
  using System;
  using System.Collections.Generic;
  using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GestionEmploi.App_Start.GestionEmploisDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GestionEmploi.App_Start.GestionEmploisDbContext context)
        {
            IDbContext db = new GestionEmploisDbContext();
            var Filieres = new List<Filiere>()
            {
              new Filiere(){FiliereId=1,Libelle="GINFO"},
              new Filiere(){FiliereId=2,Libelle="GTR"},
              new Filiere(){Libelle="GINDUS"}
            };
            db.Filieres.AddRange(Filieres);
            db.SaveChanges();
        }
    }
}
