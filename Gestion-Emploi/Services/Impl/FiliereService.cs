using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionEmploi.App_Start;
using GestionEmploi.Models;
namespace GestionEmploi.Services
{
  public class FiliereService : IFiliereService
  {
    IDbContext db;
    public FiliereService(IDbContext db)
    {
      this.db = db;
    }
    public bool create(Filiere entity)
    {
      throw new NotImplementedException();
    }

    public bool delete(int id)
    {
      throw new NotImplementedException();
    }

    public List<Filiere> getAll()
    {
      return db.Filieres.ToList();
    }

    public Filiere getByDate(DateTime d)
    {
      throw new NotImplementedException();
    }

    public Filiere getById(int id)
    {
      throw new NotImplementedException();
    }

    public Filiere getByName(string name)
    {
      throw new NotImplementedException();
    }

    public bool update(Filiere entity)
    {
      throw new NotImplementedException();
    }
  }
}