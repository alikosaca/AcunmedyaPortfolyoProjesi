using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolyoProjesi.Models;

namespace PortfolyoProjesi.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        PortfolioAcunMediaEntities1 portfolioAcunMediaEntities = new PortfolioAcunMediaEntities1();
        public ActionResult Index()
        {
            var values = portfolioAcunMediaEntities.Tbl_About.ToList();
            return View(values);
        }
    }
}
//PortfolioAcunMediaEntitiesW