using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBaseFirst.Models;
using System.Data.SqlClient;

namespace DataBaseFirst.Controllers
{
    public class DBFirstController : Controller
    {
        // GET: DBFirst
        footballEntities context = new footballEntities();
        public ActionResult Index()
        {
            List<footballdet> result=context.footballdets.Where(x=>x.Status=="Win").ToList();
            return View(result);
        }
    }
}