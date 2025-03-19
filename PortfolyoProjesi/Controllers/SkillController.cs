using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolyoProjesi.Models;

namespace PortfolyoProjesi.Controllers
{
    public class SkillController : Controller
    {
        PortfolioAcunMediaEntities1 db = new PortfolioAcunMediaEntities1();
        // GET: Skill
        public ActionResult Index()
        {
            return View();
        }
    }
}