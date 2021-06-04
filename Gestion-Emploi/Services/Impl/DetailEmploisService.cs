using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionEmploi.App_Start;
using GestionEmploi.Models;


namespace GestionEmploi.Services.Impl
{
  public class DetailEmploisService : IDAO<DetailEmplois>
  {
    IDbContext db;
    public DetailEmploisService(IDbContext db)
    {
      this.db = db;
    }

    public bool create(DetailEmplois entity)
    {
      return false;
    }

    public bool create(List<DetailEmplois> entity)
    {
      db.DetailEmplois.AddRange(entity);
      return db.SaveChanges() > 0;
    }

    public bool delete(int id)
    {
      throw new NotImplementedException();
    }

    public List<DetailEmplois> getAll()
    {
      throw new NotImplementedException();
    }

    public DetailEmplois getById(int id)
    {
      throw new NotImplementedException();
    }

    public bool update(DetailEmplois entity)
    {
      throw new NotImplementedException();
    }
  }
}