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
        PortfolioAcunMediaEntities1 aboutManager = new PortfolioAcunMediaEntities1();
        [HttpGet]
        public ActionResult Index()
        {
            var values = aboutManager.Tbl_About.Find(1);
            return View(values);
        }
        [HttpPost]
        public ActionResult Index(Tbl_About _About)
        {
            var values = aboutManager.Tbl_About.Find(1);
            values.ImageUrl = _About.ImageUrl;
            values.Title = _About.Title;
            values.Description = _About.Description;
            values.Description2 = _About.Description2;
            values.Age = _About.Age;
            values.Website = _About.Website;
            values.Phone = _About.Phone;
            values.City = _About.City;
            values.Email = _About.Email;
            values.Degree = _About.Degree;
            aboutManager.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
//PortfolioAcunMediaEntitiesW