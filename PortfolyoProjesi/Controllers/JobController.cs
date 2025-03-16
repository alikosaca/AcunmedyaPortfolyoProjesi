using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolyoProjesi.Models;

namespace PortfolyoProjesi.Controllers
{
    public class JobController : Controller
    {
        PortfolioAcunMediaEntities1 db = new PortfolioAcunMediaEntities1();
        public ActionResult Index()
        {
            var values = db.Tbl_Job.ToList();
            return View(values);
        }
        public ActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddJob(Tbl_Job _Job)
        {
            db.Tbl_Job.Add( _Job );
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditJob(int id)
        {
            var values = db.Tbl_Job.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditJob(Tbl_Job _Job)
        {
            var values = db.Tbl_Job.Find(_Job.JobID);
            values.StartDate = _Job.StartDate;
            values.EndDate = _Job.EndDate;
            values.CompanyName = _Job.CompanyName;
            values.Description = _Job.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteJob(int id)
        {
            var values = db.Tbl_Job.Find(id);
            db.Tbl_Job.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}