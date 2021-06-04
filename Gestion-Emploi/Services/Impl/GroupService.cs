using GestionEmploi.App_Start;
using GestionEmploi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEmploi.Services.Impl
{
    public class GroupService : IDAO<Group>
    {
        IDbContext db;
        public GroupService(IDbContext db)
        {
            this.db = db;
       

        }
        public bool create(Group entity)
        {
            db.Groupes.Add(entity);
             return db.SaveChanges() >0 ;
        }

        public bool delete(int id)
        {
            Group Gr = db.Groupes.Find(id);
            db.Groupes.Remove(Gr);
            return db.SaveChanges() > 0;
        }

        public List<Group> getAll()
        {
           return db.Groupes.ToList();
        }

        public Group getById(int id)
        {
            return db.Groupes.SingleOrDefault(x => x.GroupId == id);
        }

        public bool update(Group entity)
        {
            db.SaveChanges();
            return true;
        }
    }
}