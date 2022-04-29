using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Codefirst.Models;

namespace Codefirst.Controllers
{
    public class CodefirstController : Controller
    {
        // GET: Codefirst
        NWdbContext context = new NWdbContext();
        public ActionResult Index()
        {
            context.CategoriesTable.ToList();
            context.ProductsTable.ToList();
            return View();
        }
    }
}