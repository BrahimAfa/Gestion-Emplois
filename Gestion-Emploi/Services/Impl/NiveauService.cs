using GestionEmploi.App_Start;
using GestionEmploi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEmploi.Services.Impl
{
    public class NiveauService : IDAO<Niveau>
    {
        IDbContext db;
        public NiveauService(IDbContext db)
        {
            this.db = db;
        }
        public bool create(Niveau entity)
        {
            db.Niveaux.Add(entity);
            return db.SaveChanges() > 0;
        }

    public bool create(List<Niveau> entity)
    {
      throw new NotImplementedException();
    }

    public bool delete(int id)
        {
            Niveau niveau = db.Niveaux.Find(id);
            db.Niveaux.Remove(niveau);
            db.SaveChanges();
            return true;
        }

        public List<Niveau> getAll()
        {
            return db.Niveaux.ToList();

        }

        public Niveau getById(int id)
        {
            Niveau niveau = db.Niveaux.SingleOrDefault(x => x.NiveauId == id);
            return niveau;
        }

        public bool update(Niveau entity)
        {
            db.SaveChanges();
            return true;
        }
    }
}