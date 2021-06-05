using GestionEmploi.Models;
using GestionEmploi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEmploi.Controllers
{
    public class LocalController : Controller
    {
        IDAO<Local> serv;
        public LocalController(IDAO<Local> serv)
        {
            this.serv = serv;
        }
        // GET: Local
        public ActionResult Local(Local l)
        {
            if (l != null)
                return View(l);
            else
                return View();
        }

        [HttpPost]
        public ActionResult LocalAdd(Local l)
        {
            if (ModelState.IsValid)
            {
                var loc = new Local();
                loc.LocalId = l.LocalId;
                loc.Libelle = l.Libelle;
                loc.Type = l.Type;
                loc.Capacity = l.Capacity;
                loc.Localisation = l.Localisation;

                if (l.LocalId == 0)
                {
                    serv.create(loc);
                }
                else        
                {
                    var loca = serv.getById(l.LocalId);
                    loca.Libelle = l.Libelle;
                    loca.Type = l.Type;                    
                    loca.Capacity = l.Capacity;
                    loca.Localisation = l.Localisation;
                    serv.update(loc);
                }
            }
            
            return View("Index");
        }

        public ActionResult Index()
        {
            var loc = serv.getAll();
            return View(loc);
        }

        
        public ActionResult Delete(int id)
        {
            serv.delete(id);
            var list = serv.getAll();
            return View("Index", list);
        }
    }
}