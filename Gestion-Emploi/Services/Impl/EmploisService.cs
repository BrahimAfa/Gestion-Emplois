using GestionEmploi.App_Start;
using GestionEmploi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEmploi.Services.Impl
{
  public class EmploisService : IDAO<Emplois>
  {
    IDbContext db;
    public EmploisService(IDbContext db)
    {
      this.db = db;
    }

    public bool create(Emplois entity)
    {
      db.Emplois.Add(entity);
      return db.SaveChanges() >0;
    }

    public bool create(List<Emplois> entity)
    {
      throw new NotImplementedException();
    }

    public bool delete(int id)
    {
      throw new NotImplementedException();
    }

    public List<Emplois> getAll()
    {
      throw new NotImplementedException();
    }

    public Emplois getById(int id)
    {
      throw new NotImplementedException();
    }

    public bool update(Emplois entity)
    {
      throw new NotImplementedException();
    }
  }
}