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
    public class FiliereController : Controller
    {
        GestionEmploisDbContext db = new GestionEmploisDbContext();

        public IDAO<Filiere> dao;
        public FiliereController(IDAO<Filiere> dao)
        {
            this.dao = dao;
        }
        
        // GET: Filiere
        public ActionResult Filiere()
        {
             List<Filiere> liste = dao.getAll();
            ViewData["list"] = liste;
            return View();
        }
    
       
        public ActionResult Delete(int id)
        {
            dao.delete(id);
            return RedirectToAction("Filiere");
        }
        public ActionResult Create()
        {
            
            return View("Create");
        }
       [HttpPost]
      public ActionResult AddFiliere(Filiere filiere)
        {
            Filiere f = new Filiere
            {
                Libelle = filiere.Libelle
            };
              dao.create(f);
            return RedirectToAction("Filiere");

        }

    }
}