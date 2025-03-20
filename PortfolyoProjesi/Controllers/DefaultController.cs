using PortfolyoProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolyoProjesi.Models;

namespace PortfolyoProjesi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        PortfolioAcunMediaEntities1 db = new PortfolioAcunMediaEntities1();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartiaMain()
        {
            var values = db.Tbl_Sider.Find(1);
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.Tbl_About.Find(1);
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.Tbl_About.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialEducation()
        {
            var values = db.Tbl_Educatiton.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialJob()
        {
            var values = db.Tbl_Job.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialPorject()
        {
            var values = db.Tbl_Project.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = db.Tbl_Testimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialServices()
        {
            var deger = db.Tbl_Service.ToList();
            return PartialView(deger);
        }
        public PartialViewResult PartialContact()
        {
            var values = db.Tbl_Contact.ToList();
            return PartialView(values);
        }

        public ActionResult PartialMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult PartialMessage(Tbl_Message message)
        {
            db.Tbl_Message.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");
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
        public ActionResult PartialFooter()
        {
            return PartialView();
        }
    }
}