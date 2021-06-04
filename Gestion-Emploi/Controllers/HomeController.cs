using GestionEmploi.Models;
using GestionEmploi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEmploi.Controllers
{
  public class HomeController : Controller
  {
    // IDAO<Filiere> dao;
    // or 
    IDAO<Filiere> dao;
    public HomeController(IDAO<Filiere> dao)
    {
      this.dao = dao;
    }
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}