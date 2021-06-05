using GestionEmploi.App_Start;
using GestionEmploi.Models;
using GestionEmploi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEmploi.Controllers
{
    public class NiveauController : Controller
    {
        GestionEmploisDbContext db = new GestionEmploisDbContext();

        public IDAO<Niveau> dao;
        public IDAO<Filiere> daof;
        public NiveauController(IDAO<Niveau> dao, IDAO<Filiere> daof)
        {
            this.dao = dao;
            this.daof = daof;
        }

        public ActionResult Index()
        {
            List<Niveau> liste = dao.getAll();
            ViewData["list"] = liste;
            return View(liste);
          
        }
        public ActionResult Create()
        {
          //  IEnumerable<SelectListItem> items = db.Filieres.Select(c => new SelectListItem
            //{
              //  Value = c.FiliereId.ToString(),
                //Text = c.Libelle

            //});
            ViewBag.filieres = new SelectList(db.Filieres, "FiliereId", "Libelle");
            return View();
           
        }
        [HttpPost]
        public ActionResult AddNiveau(Niveau niveau)
        {
            Niveau n = new Niveau
            {
               Code = niveau.Code,
               libelle = niveau.libelle ,
               FiliereId = niveau.FiliereId
            };
            dao.create(n);
      List<Niveau> liste = dao.getAll();
      ViewData["list"] = liste;
      return View("Index", liste);

        }
        public ActionResult Delete(int id)
        {
            dao.delete(id);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            ViewBag.filieres = new SelectList(db.Filieres, "FiliereId", "Libelle");
            Niveau niveau = dao.getById(id);
            return View(niveau);

        }
        [HttpPost]
        public ActionResult Update(Niveau niveau)
        {
            Niveau niveau1 = dao.getById(niveau.NiveauId);
            niveau1.Code = niveau.Code;
            niveau1.libelle = niveau.libelle;
            niveau1.FiliereId = niveau.FiliereId;
            dao.update(niveau1);
            return RedirectToAction("Index");

        }

    }
}