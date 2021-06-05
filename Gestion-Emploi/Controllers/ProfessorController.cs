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
    public class ProfessorController : Controller
    {

        IProfessorService dao;

        public ProfessorController(IProfessorService dao)
        {
            this.dao = dao;
        }

        
         public ActionResult AddProfessor()
        {
            
                return View();
            
           
        }
        [HttpPost]
        public ActionResult AddProfessorToBd(Professor professor)
        {
            dao.create(professor);         
            return RedirectToAction("ListProfessor");
        }


        public ActionResult ListProfessor()
        {
            List<Professor> professors = dao.getAll();
            ViewData["list"] = professors;
            return View();
        }
        public ActionResult Delete(int id)
        {
            dao.delete(id);
            return RedirectToAction("ListProfessor");
        }

        public ActionResult EditeProfessor(int id)
        {
            Professor professor = dao.getById(id);
            return View(professor);
        }

        [HttpPost]
        public ActionResult EditProfessorDb(Professor professor)
        {
            
                Professor profUpdate = dao.getById(professor.ProfessorId);
                profUpdate.Email = professor.Email;
                profUpdate.LastName = professor.LastName;
                profUpdate.FirstName = professor.FirstName;
                dao.update(profUpdate);
               
          
            return RedirectToAction("ListProfessor");
        }
    }
}