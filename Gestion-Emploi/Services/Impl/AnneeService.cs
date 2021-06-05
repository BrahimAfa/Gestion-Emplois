using GestionEmploi.App_Start;
using GestionEmploi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace GestionEmploi.Services.Impl
{
    public class AnneeService : IDAO<Annee> 

    {
        IDbContext db;
        public AnneeService(IDbContext db)
        {
            this.db = db;
        }

        public bool create(Annee entity)
        {


            db.Annees.Add(entity);
            return db.SaveChanges() >0 ;

        }

    public bool create(List<Annee> entity)
    {
      throw new NotImplementedException();
    }

    public bool delete(int id)
        {
            Annee An = db.Annees.Find(id);
            db.Annees.Remove(An);
            return db.SaveChanges() > 0;
        }

        public List<Annee> getAll()
        {
            return db.Annees.ToList();

        }

        public Annee getById(int id)
        {
            Annee a = db.Annees.SingleOrDefault(x => x.AnneeId == id);
            return a;

            //    public bool update(Annee entity)
            //{
            //        db.SaveChanges();
            //        return true;
            //    }
        }

        public bool update(Annee entity)
        {
            db.SaveChanges();
            return true;
        }

        public void UPDATEId(int id)
        {
            db.SaveChanges();

        }
    }
}