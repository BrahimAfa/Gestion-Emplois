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
    IDbContext db;
    IDAO<Emplois> emploisDao;
    IDAO<DetailEmplois> detailDao;
    IDAO<Seance> seanceDao;
    IDAO<Filiere> filiereDao;
    IDAO<Annee> AnneDao;
    IDAO<Niveau> NiveauDao;

    public HomeController(IDbContext db ,IDAO<Seance> seanceDao ,IDAO<Emplois> emploisDao,IDAO<DetailEmplois> detailDao)
    {
      this.db = db;
      this.seanceDao = seanceDao;
      this.emploisDao = emploisDao;
      this.detailDao = detailDao;
    }
    public ActionResult Index()
    {

    
      ViewBag.globalSeanc = getViewSeancebyDays(null);  
      return View();
    }
    public viewSeances getViewSeancebyDays(List<DetailEmplois> details)
    {
      var seances = seanceDao.getAll();

      viewSeances v = new viewSeances();

      foreach (var item in seances)
      {
        string s = $"{item.HeurDebut} - {item.HeurFin}";
        v.seances.Add(s);
        DetailEmplois detail = null;
        if(!(details is null))
        {
        }
        var j = new viewseanceForDay() { id = item.SeanceId, name = s, Detail = detail };
        if (v.seanceByDay.ContainsKey(item.Jour))
        {
          v.seanceByDay[item.Jour].Add(j);
        }
        else
        {
          v.seanceByDay.Add(item.Jour, new HashSet<viewseanceForDay>(j) { j });
        }
      }
      return v;
    }
    public ActionResult About()
    {

      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Emplois(int id)
    {
      var emploi = db.Emplois.Where(e => e.EmploisId == id).SingleOrDefault();
      if(emploi is null) return View("About");
      var detailemplois = db.DetailEmplois.Where(d => d.EmploisId == emploi.EmploisId).ToList();
      CrossRefEmploisDetail cross = new CrossRefEmploisDetail()
      {
        emplois = emploi,
        detailEmplois = detailemplois,
      };
      ViewBag.globalSeanc = getViewSeancebyDays(detailemplois);

      return View(cross);
    }

    [HttpPost]
    public JsonResult jsonData(CrossRefEmploisDetail data)
    {
      Debug.WriteLine("this JSon Is Called");
      Debug.WriteLine(data.emplois);
      Debug.WriteLine(data.detailEmplois.Count);

      var b = emploisDao.create(data.emplois);
      data.detailEmplois.ForEach(e => e.EmploisId = data.emplois.EmploisId);
      var j = detailDao.create(data.detailEmplois);
      Debug.WriteLine("emplois " + j);

      return Json(new {name="added yees" },JsonRequestBehavior.AllowGet);
    }

    
    public JsonResult Filieres()
    {
      var data = db.Filieres.ToList();
      return Json(data, JsonRequestBehavior.AllowGet);
    }

    public JsonResult Semains()
    {
      var data = db.Semaines.ToList();
      return Json(data, JsonRequestBehavior.AllowGet);
    }

    public JsonResult Annnees()
    {
      var data = db.Annees.ToList();
      return Json(data, JsonRequestBehavior.AllowGet);
    }

    public JsonResult Niveaux(int id)
    {
      var data = db.Niveaux.Where(n=>n.FiliereId==id).ToList();
      return Json(data, JsonRequestBehavior.AllowGet);
    }
    [HttpPost]
    public JsonResult deleteSeance(int id)
    {
      var data = db.DetailEmplois.Where(n => id == n.DetailEmploisId).SingleOrDefault();
      db.DetailEmplois.Remove(data);
      db.SaveChanges();
      return Json(data, JsonRequestBehavior.AllowGet);
    }


    public JsonResult Cours(int? id)
    {
      List<Cour> data;
      if (id is null)
      {
        data = db.Cours.ToList();

      }
      else
      {
        
        data = db.Cours.Where(c => c.NiveauId == id).ToList();
      }
      return Json(data, JsonRequestBehavior.AllowGet);
    }

    public JsonResult Locals(int? idSemain,int? idCours)
    {
      var data = db.Locals.ToList();
      return Json(data, JsonRequestBehavior.AllowGet);
    }

    [HttpPost]
    public JsonResult updateDetailEmplois(DetailEmplois detail)
    {
      var data = db.DetailEmplois.Where(d=>d.DetailEmploisId==detail.DetailEmploisId).SingleOrDefault();
      db.Entry(data).CurrentValues.SetValues(detail);
      return Json(db.SaveChanges(), JsonRequestBehavior.AllowGet);
    }


    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";
      return View();
    }
  }
}