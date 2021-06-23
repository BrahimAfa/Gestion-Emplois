using GestionEmploi.Models;
using GestionEmploi.Services;
using GestionEmploi.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa;

namespace GestionEmploi.Controllers
{
    public class SemaineController : Controller
    {
        ISemaineService serv;

        public SemaineController(ISemaineService serv)
        {
            this.serv = serv;
        }

        // GET: Semaine
        public ActionResult Semaine(Semaine sem)
        {
            if(sem != null)
            {
                return View(sem);
            }
            else
                return View();
        }

        [HttpPost]
        public ActionResult SemaineAdd( Semaine s)
        {
            if(ModelState.IsValid)
            {
                var sem = new Semaine();
                sem.SemaineId = s.SemaineId;
                sem.libelle = s.libelle;
                sem.DateDebut = s.DateDebut;
                sem.DateFin = s.DateFin;

                if(s.SemaineId==0)
                {
                    serv.create(sem);
                }
                else
                {
                    var sema = serv.getById(s.SemaineId);
                    sema.libelle = s.libelle;
                    sema.DateDebut = s.DateDebut;
                    sema.DateFin = s.DateFin;
                    serv.update(sem);
                }

                
            }
            
            return View("Semaine");
        }

        public ActionResult SemaineList()
        {
            ViewBag.list = serv.getAll();
            return View();
        }

        public ActionResult Semainepdf()
        {
            return View();
        }

        public ActionResult SemainepdfImp()
        {
            return View();
        }

        public ActionResult Semainepdff()
        {
            return new Rotativa.ActionAsPdf("SemainepdfImp");
        }

        public ActionResult Delete(int id)
        {
            serv.delete(id);
            var list = serv.getAll();
            return View("SemaineList", list);
        }
    }
}