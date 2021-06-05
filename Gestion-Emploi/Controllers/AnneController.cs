using GestionEmploi.App_Start;
using GestionEmploi.Models;
using GestionEmploi.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEmploi.Controllers
{
    public class AnneController : Controller
    {


        public IDbContext db;
        public IDAO<Annee> dao;
        public AnneController(IDAO<Annee> dao, IDbContext db)
        {
            this.dao = dao;
            this.db = db;
        }
        // GET: Anne+
        public ActionResult AJouter_Annee()
        {

            List<Annee> liste = dao.getAll();
            ViewData["list"] = liste;
            // return Json(liste,JsonRequestBehavior.AllowGet);
            return View();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteAnnee(int id)
        {
            Console.WriteLine(id);
            dao.delete(id);
            return RedirectToAction("AJouter_Annee");
        }

        public ActionResult Create()
        {

            return View("Create");
        }



        [HttpPost]
        public ActionResult AJouter_Annee(Annee an)
        {
            Debug.WriteLine(an);
            var j = dao.create(an);
            Debug.WriteLine(j);
            return RedirectToAction("AJouter_Annee");
        }

        
        
        public ActionResult EDIT(int id)
        {
            Annee annee = dao.getById(id);
            return View(annee);

        }

       

        [HttpPost]
        public ActionResult Update(Annee annee)
        {

       
                
                    var annn = dao.getById(annee.AnneeId);
                    annn.Libelle = annee.Libelle;
                    annn.DateDebut = annee.DateDebut;
                    annn.DateFin = annee.DateFin;
                    dao.update(annn);
                
      return RedirectToAction("AJouter_Annee");

    }
}
}