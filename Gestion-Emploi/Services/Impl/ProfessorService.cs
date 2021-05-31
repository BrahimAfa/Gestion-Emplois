using GestionEmploi.App_Start;
using GestionEmploi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEmploi.Services.Impl
{
    public class ProfessorService : IProfessorService
    {
        IDbContext db;
        public ProfessorService(IDbContext db)
        {
            this.db = db;
        }


        public bool create(Professor entity)
        {
            db.Professors.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool delete(int id)
        {
            var profSelected = db.Professors.Where<Professor>(x => x.ProfessorId == id).First();
            db.Professors.Remove(profSelected);
            return db.SaveChanges() > 0;
        }

        public List<Professor> getAll()
        {
            return db.Professors.ToList();
        }

        public Professor getByEmail(string Email)
        {
            var prof= db.Professors.Where<Professor>(x => x.Email == Email).First();
            return prof;
        }

        public Professor getByFirstName(string firstName)
        {
            var prof = db.Professors.Where<Professor>(x => x.FirstName == firstName).First();
            return prof;
        }

        public Professor getById(int id)
        {
            Professor prof = db.Professors.SingleOrDefault(x => x.ProfessorId == id);
            return prof;
        }

        public Professor getByLastName(string lastName)
        {
            var prof = db.Professors.Where<Professor>(x => x.LastName == lastName).First();
            return prof;
        }

        public bool update(Professor entity)
        {
            
            db.SaveChanges();
            return true;
        }
    }
}