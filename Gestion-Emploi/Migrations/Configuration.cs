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
      var Niveaus = new List<Niveau>()
            {
              new Niveau(){FiliereId=1,libelle="CP1",NiveauId=1},
              new Niveau(){NiveauId=2,libelle="cp2",FiliereId=2},
              new Niveau(){NiveauId=3,libelle="GTR3",FiliereId=2}
            };
      var Professors = new List<Professor>()
            {
              new Professor(){Email="email",FirstName="prof1",LastName="prof2",ProfessorId=1},
            };
      var Cours = new List<Cour>()
            {
              new Cour(){CourId=1,Libelle="JAVA",NiveauId=1,ResponsableId=1},
            };
      var Semaine = new List<Semaine>()
            {
              new Semaine(){SemaineId=1,DateDebut=new DateTime(2021,01,01),DateFin= new DateTime(2021,01,07),libelle="Week1"},
            };
      var Locals = new List<Local>()
            {
              new Local(){Capacity="20",Libelle="SALLE 9",LocalId=1,Localisation="lta7t",Type="??"},
              new Local(){Capacity="20",Libelle="SALLE 10",LocalId=2,Localisation="lta7t",Type="??"},
              new Local(){Capacity="20",Libelle="SALLE 11",LocalId=3,Localisation="lta7t",Type="??"},

            };

        var Annees = new List<Annee>()
            {
              new Annee(){ AnneeId=1, DateDebut=new DateTime(2021,01,01),DateFin= new DateTime(2021,01,07),Libelle="2020/2021"},

            };

      var Seances = new List<Seance>()
            {
              new Seance(){ SeanceId=1, HeurDebut= "08:00", HeurFin="10:00", Jour="Lundi"  },
              new Seance(){ SeanceId=2, HeurDebut= "10:20", HeurFin="12:00", Jour="Lundi"  },
              new Seance(){ SeanceId=3, HeurDebut= "14:00", HeurFin="16:00", Jour="Lundi"  },
              new Seance(){ SeanceId=4, HeurDebut= "16:20", HeurFin="18:00", Jour="Lundi"  },
              new Seance(){ SeanceId=5, HeurDebut= "08:00", HeurFin="10:00", Jour="Mardi"  },
              new Seance(){ SeanceId=6, HeurDebut= "10:20", HeurFin="12:00", Jour="Mardi"  },
              new Seance(){ SeanceId=7, HeurDebut= "14:00", HeurFin="16:00", Jour="Mardi"  },
              new Seance(){ SeanceId=8, HeurDebut= "16:20", HeurFin="18:00", Jour="Mardi"  },
              new Seance(){ SeanceId=9, HeurDebut= "08:00", HeurFin="10:00", Jour="Mercredi"  },
              new Seance(){ SeanceId=10, HeurDebut= "10:20", HeurFin="12:00", Jour="Mercredi"  },
              new Seance(){ SeanceId=11, HeurDebut= "14:00", HeurFin="16:00", Jour="Mercredi"  },
              new Seance(){ SeanceId=12, HeurDebut= "16:20", HeurFin="18:00", Jour="Mercredi"  },
              new Seance(){ SeanceId=13, HeurDebut= "08:00", HeurFin="10:00", Jour="Jeudi"  },
              new Seance(){ SeanceId=14, HeurDebut= "10:20", HeurFin="12:00", Jour="Jeudi"  },
              new Seance(){ SeanceId=15, HeurDebut= "14:00", HeurFin="16:00", Jour="Jeudi"  },
              new Seance(){ SeanceId=16, HeurDebut= "16:20", HeurFin="18:00", Jour="Jeudi"  },
              new Seance(){ SeanceId=17, HeurDebut= "08:00", HeurFin="10:00", Jour="Vendredi"  },
              new Seance(){ SeanceId=18, HeurDebut= "10:20", HeurFin="12:00", Jour="Vendredi"  },
              new Seance(){ SeanceId=19, HeurDebut= "14:00", HeurFin="16:00", Jour="Vendredi"  },
              new Seance(){ SeanceId=20, HeurDebut= "16:20", HeurFin="18:00", Jour="Vendredi"  },
              new Seance(){ SeanceId=21, HeurDebut= "08:00", HeurFin="10:00", Jour="Samedi"  },
              new Seance(){ SeanceId=22, HeurDebut= "10:20", HeurFin="12:00", Jour="Samedi"  },
              new Seance(){ SeanceId=23, HeurDebut= "14:00", HeurFin="16:00", Jour="Samedi"  },
              new Seance(){ SeanceId=24, HeurDebut= "16:20", HeurFin="18:00", Jour="Samedi"  },

            };
      
            db.Seances.AddRange(Seances);
            db.Annees.AddRange(Annees);
            db.Professors.AddRange(Professors);
            db.Locals.AddRange(Locals);
            db.Semaines.AddRange(Semaine);
            db.Cours.AddRange(Cours);
            db.Filieres.AddRange(Filieres);
            db.Niveaux.AddRange(Niveaus);
            db.SaveChanges();
        }
    }
}
