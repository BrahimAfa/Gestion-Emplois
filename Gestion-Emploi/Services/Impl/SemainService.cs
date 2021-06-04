﻿using GestionEmploi.App_Start;
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

    public bool create(List<Semaine> entity)
    {
      throw new NotImplementedException();
    }

    public bool delete(int id)
    {
      throw new NotImplementedException();
    }

    public List<Semaine> getAll()
    {
      throw new NotImplementedException();
    }

    public Semaine getById(int id)
    {
      throw new NotImplementedException();
    }

    public bool update(Semaine entity)
    {
      throw new NotImplementedException();
    }
  }
}