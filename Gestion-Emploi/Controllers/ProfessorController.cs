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

        
         public ActionResult AddProfessor(Professor professor)
        {
            if (professor != null)
            {
                return View(professor);
            }
            else
            {
                return View();
            }
           
        }
        [HttpPost]
        public ActionResult AddProfessorToBd(Professor professor)
        {
            //if (professor.ProfessorId == null)
            //{
                dao.create(professor);
            //}
            //else
            //{
            //    var prof = dao.getById(professor.ProfessorId);
            //    prof.LastName = professor.LastName;
            //    prof.FirstName = professor.FirstName;
            //    prof.Email = professor.Email;
            //    dao.update(prof);
            //}
            
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
    }
}