using GestionEmploi.App_Start;
using GestionEmploi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GestionEmploi.Services.Impl
{
  public class SemainService : ISemaineService
  {
    IDbContext db;
    public SemainService(IDbContext db)
    {
      this.db = db;
    }

    public bool create(Semaine entity)
    {
      db.Semaines.Add(entity);
      return db.SaveChanges() > 0;
    }

    public bool delete(int id)
    {
            var sem = db.Semaines.Where<Semaine>(x => x.SemaineId == id).First();
            db.Semaines.Remove(sem);
            return db.SaveChanges() > 0;
    }

    public List<Semaine> getAll()
    {
            return db.Semaines.ToList();
    }

    public Semaine getById(int id)
    {
            var  sem = db.Semaines.Where<Semaine>(x => x.SemaineId == id).First();
            return sem;
    }

    public bool update(Semaine entity)
    {
            //var sem = db.Semaines.Where<Semaine>(x => x.SemaineId == entity.SemaineId).First();
            db.SaveChanges();
            return true;
    }

        public void UpdateId(int id)
        {
            db.SaveChanges();

        }
    }
}