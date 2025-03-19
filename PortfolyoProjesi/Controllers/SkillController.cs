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
        public ActionResult Index()
        {
            var values = db.Tbl_Skill.ToList();
            return View(values);
        }
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(Tbl_Skill _Skill)
        {
            db.Tbl_Skill.Add(_Skill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditSkill(int id)
        {
            var values = db.Tbl_Skill.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditSkill(Tbl_Skill _skill)
        {
            var values = db.Tbl_Skill.Find(_skill.SkillID);
            if (_skill != null)
            {
                values.SkillName = _skill.SkillName;
                values.Description = _skill.Description;
                db.SaveChanges();
            }
            else
            {
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSkill(int id)
        {
            var values = db.Tbl_Skill.Find(id);
            db.Tbl_Skill.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}