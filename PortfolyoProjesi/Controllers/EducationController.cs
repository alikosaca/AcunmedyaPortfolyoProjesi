using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolyoProjesi.Models;

namespace PortfolyoProjesi.Controllers
{
    public class EducationController : Controller
    {
        PortfolioAcunMediaEntities1 db = new PortfolioAcunMediaEntities1();

        // GET: Education
        public ActionResult Index()
        {
            var values = db.Tbl_Educatiton.ToList();
            return View(values);
        }
        public ActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEducation(Tbl_Educatiton _Educatiton)
        {
            var values = db.Tbl_Educatiton.Add(_Educatiton);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditEducation(int id)
        {
            var values = db.Tbl_Educatiton.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditEducation(Tbl_Educatiton _Educatiton)
        {
            var values = db.Tbl_Educatiton.Find(_Educatiton.EducationID);
            values.StartYear = _Educatiton.StartYear;
            values.EndYear = _Educatiton.EndYear;
            values.Name = _Educatiton.Name;
            values.Description = _Educatiton.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteEducation(int id)
        {
            var values = db.Tbl_Educatiton.Find(id);
            db.Tbl_Educatiton.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}