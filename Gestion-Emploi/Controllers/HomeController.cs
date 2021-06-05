using GestionEmploi.App_Start;
using GestionEmploi.Models;
using GestionEmploi.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEmploi.Controllers
{
  public class HomeController : Controller
  {
    // IDAO<Filiere> dao;
    // or 

    public HomeController()
    {
    }
    public ActionResult Index()
    {      return View();
    }
    

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";
      return View();
    }
  }
}