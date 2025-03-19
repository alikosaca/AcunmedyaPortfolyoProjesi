using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolyoProjesi.Models;
namespace PortfolyoProjesi.Controllers
{
    public class TestimonialController : Controller
    {
        PortfolioAcunMediaEntities1 db = new PortfolioAcunMediaEntities1();
        public ActionResult Index()
        {
            var vaules = db.Tbl_Testimonial.ToList();
            return View(vaules);
        }
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(Tbl_Testimonial _Testimonial)
        {
            var values = db.Tbl_Testimonial.Add(_Testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditTestimonial(int id)
        {
            var values = db.Tbl_Testimonial.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditTestimonial(Tbl_Testimonial _Testimonial)
        {
            var values = db.Tbl_Testimonial.Find(_Testimonial.TestimonialID);
            if (_Testimonial != null)
            {
                values.Title = _Testimonial.Title;
                values.TestimonialName = _Testimonial.TestimonialName;
                values.Description1 = _Testimonial.Description1;
                values.Description2 = _Testimonial.Description2;
                values.ImageUrl = _Testimonial.ImageUrl;
                db.SaveChanges();
            }
            else
            {
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.Tbl_Testimonial.Find(id);
            db.Tbl_Testimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}