using GestionEmploi.App_Start;
using GestionEmploi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEmploi.Services.Impl
{
    public class CourService : ICourService
    {
        IDbContext db;

        public CourService(IDbContext db)
        {
            this.db = db;
        }

        public bool create(Cour entity)
        {
            db.Cours.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool delete(int id)
        {
            var cour = db.Cours.Where<Cour>(x => x.CourId == id).First();
            db.Cours.Remove(cour);
            return db.SaveChanges() > 0;
        }

        public List<Cour> getAll()
        {
            return db.Cours.ToList();
        }

        public Cour getById(int id)
        {
            var cour = db.Cours.Where<Cour>(x => x.CourId == id).First();
            return cour;
        }

        public Cour getByNiveau(int niveauId)
        {
            throw new NotImplementedException();
        }

        public Cour getByProfessor(int professorId)
        {
            throw new NotImplementedException();
        }

        public bool update(Cour entity)
        {
            db.SaveChanges();
            return true;
        }
    }
}