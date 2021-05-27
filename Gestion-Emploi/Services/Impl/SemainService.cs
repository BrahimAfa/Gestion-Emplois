using GestionEmploi.App_Start;
using GestionEmploi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEmploi.Services.Impl
{
  public class SemainService : IDAO<Semaine>
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
      throw new NotImplementedException();
    }
  }
}