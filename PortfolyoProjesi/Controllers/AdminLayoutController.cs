using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolyoProjesi.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartialHead()
        {
            return PartialView();
        }
        public ActionResult PartialMenu()
        {
            return PartialView();
        }
        public ActionResult PartialScript()
        {
            return PartialView();
        }
    }
}