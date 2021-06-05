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
    public class GroupController : Controller
    {

        public IDbContext db;
        public IDAO<Group> dao;
        public GroupController(IDAO<Group> dao, IDbContext db)
        {
            this.dao = dao;
            this.db = db;

        }

        // GET: Group
       

        public ActionResult Cree_Group()
        {

            List<Group> liste = dao.getAll();
            ViewData["list"] = liste;
            // return Json(liste,JsonRequestBehavior.AllowGet);
            return View();
        }

        [HttpPost]
        public ActionResult Ajouter_group(Group gr)
        {
            Debug.WriteLine(gr);
            var j = dao.create(gr);
            Debug.WriteLine(j);
            return RedirectToAction("Index");
        }


        public ActionResult Index()
        {
            List<Group> liste = dao.getAll();
            ViewData["list"] = liste;
            return View();
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteGroup(int id)
        {
            Console.WriteLine(id);
            dao.delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Modifier_Gr(int id)
        {
            Group group = dao.getById(id);
            return View(group);

        }



        [HttpPost]
        public ActionResult Update(Group group)
        {



            var gr = dao.getById(group.GroupId);
            gr.Libelle = group.Libelle;

            dao.update(gr);

            return RedirectToAction("Index");


        }
    }
}