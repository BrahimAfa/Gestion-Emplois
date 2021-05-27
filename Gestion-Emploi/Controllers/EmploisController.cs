using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEmploi.Controllers
{
    public class EmploisController : Controller
    {
        // GET: Emplois
        public ActionResult Index()
        {
            return View();
        }
    }
}