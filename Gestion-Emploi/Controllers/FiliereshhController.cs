using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GestionEmploi.App_Start;
using GestionEmploi.Models;

namespace GestionEmploi.Controllers
{
    public class FiliereshhController : Controller
    {
        private GestionEmploisDbContext db = new GestionEmploisDbContext();

        // GET: Filiereshh
        public ActionResult Index()
        {
            return View(db.Filieres.ToList());
        }

        // GET: Filiereshh/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filiere filiere = db.Filieres.Find(id);
            if (filiere == null)
            {
                return HttpNotFound();
            }
            return View(filiere);
        }

        // GET: Filiereshh/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Filiereshh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FiliereId,Libelle")] Filiere filiere)
        {
            if (ModelState.IsValid)
            {
                db.Filieres.Add(filiere);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(filiere);
        }

        // GET: Filiereshh/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filiere filiere = db.Filieres.Find(id);
            if (filiere == null)
            {
                return HttpNotFound();
            }
            return View(filiere);
        }

        // POST: Filiereshh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FiliereId,Libelle")] Filiere filiere)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filiere).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(filiere);
        }

        // GET: Filiereshh/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filiere filiere = db.Filieres.Find(id);
            if (filiere == null)
            {
                return HttpNotFound();
            }
            return View(filiere);
        }

        // POST: Filiereshh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Filiere filiere = db.Filieres.Find(id);
            db.Filieres.Remove(filiere);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
