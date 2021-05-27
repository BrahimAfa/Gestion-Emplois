using GestionEmploi.Models;
using GestionEmploi.Services;
using GestionEmploi.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEmploi.Controllers
{
    public class SemaineController : Controller
    {
        IDAO<Semaine> serv;

        public SemaineController(IDAO<Semaine> serv)
        {
            this.serv = serv;
        }

        // GET: Semaine
        public ActionResult Semaine()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SemaineAdd( Semaine s)
        {
            var sem = new Semaine();
            sem.libelle = s.libelle;
            sem.DateDebut = sem.DateDebut;
            sem.DateFin = sem.DateFin;

            serv.create(sem);
            return View();
        }
    }
}