using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionEmploi.App_Start;
using GestionEmploi.Models;
namespace GestionEmploi.Services
{
  public class FiliereService : IDAO<Filiere>
  {
    IDbContext db;
    public FiliereService(IDbContext db)
    {
      this.db = db;
    }
    public bool create(Filiere entity)
    {
                db.Filieres.Add(entity);
            return db.SaveChanges() > 0;
        }

    public bool delete(int id)
    {

            Filiere filiere = db.Filieres.Find(id);
            db.Filieres.Remove(filiere);
            db.SaveChanges();
            return true;
    
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
            Filiere f = db.Filieres.SingleOrDefault(x => x.FiliereId == id);
            return f;

        }

        public bool update(Filiere entity)
    {
            db.SaveChanges();
            return true;
        }
  }
}