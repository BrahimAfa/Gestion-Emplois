using GestionEmploi.App_Start;
using GestionEmploi.Models;
using GestionEmploi.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GestionEmploi.Controllers
{
    public class CourController : Controller
    {
        GestionEmploisDbContext db = new GestionEmploisDbContext();
        ICourService dao;
        IProfessorService daoProf;
        

        public CourController(ICourService dao)
        {
            this.dao = dao;
        }


        public ActionResult ListCour()
        {
            List<Cour> cours = dao.getAll();
            ViewData["list"] = cours;
            return View();
        }


        public ActionResult AddCour()
        {
            ViewBag.profs = new SelectList(db.Professors, "ProfessorId","LastName");
            ViewBag.niveaux = new SelectList(db.Niveaux, "NiveauId", "libelle");
            return View();
        }

        [HttpPost]
        public ActionResult AddCour(Cour cour)
        {
            dao.create(cour);
            return RedirectToAction("ListCour");
        }

        public ActionResult Delete(int id)
        {
            dao.delete(id);
            return RedirectToAction("ListCour");
        }

        public ActionResult EditeCour(int id)
        {
            Cour cour = dao.getById(id);
            return View(cour);
        }
    }
}