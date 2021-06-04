using GestionEmploi.App_Start;
using GestionEmploi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEmploi.Services.Impl
{
  public class SeanceService : IDAO<Seance>
  {
    IDbContext db;
    public SeanceService(IDbContext db)
    {
      this.db = db;
    }

    public bool create(Seance entity)
    {
      throw new NotImplementedException();
    }

    public bool create(List<Seance> entity)
    {
      throw new NotImplementedException();
    }

    public bool delete(int id)
    {
      throw new NotImplementedException();
    }

    public List<Seance> getAll()
    {
      return db.Seances.ToList();
    }

    public Seance getById(int id)
    {
      throw new NotImplementedException();
    }

    public bool update(Seance entity)
    {
      throw new NotImplementedException();
    }
  }
}