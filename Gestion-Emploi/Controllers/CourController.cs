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
    public class CourController : Controller
    {
        GestionEmploisDbContext db = new GestionEmploisDbContext();

        public IDAO<Cour> dao;
        public CourController(IDAO<Cour> dao)
        {
            this.dao = dao;
        }

        public ActionResult Cour()
        {
            List<Filiere> liste = dao.getAll();
            ViewData["list"] = liste;
            return View();
            
        }
    }
}