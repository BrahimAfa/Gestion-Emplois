using GestionEmploi.App_Start;
using GestionEmploi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEmploi.Services.Impl
{
    public class LocalService : IDAO<Local>
    {
        IDbContext db;
        public LocalService(IDbContext db)
        {
            this.db = db;
        }
        public bool create(Local entity)
        {
            db.Locals.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool delete(int id)
        {
            var loc = db.Locals.Where<Local>(x => x.LocalId == id).First();
            db.Locals.Remove(loc);
            return db.SaveChanges() > 0;

        }

        public List<Local> getAll()
        {
            return db.Locals.ToList();
        }

        public Local getById(int id)
        {
            var loc = db.Locals.Where<Local>(x => x.LocalId == id).First();
            return loc;
        }

        public bool update(Local entity)
        {
            db.SaveChanges();
            return true;
        }
    }
}