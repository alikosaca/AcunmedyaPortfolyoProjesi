using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolyoProjesi.Models;

namespace PortfolyoProjesi.Controllers
{
    public class ProjectController : Controller
    {
        PortfolioAcunMediaEntities1 ProjectManager = new PortfolioAcunMediaEntities1();
        // GET: Project
        public ActionResult Index()
        {
            var values = ProjectManager.Tbl_Project.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProject(Tbl_Project _Project)
        {
            ProjectManager.Tbl_Project.Add(_Project);
            ProjectManager.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditProject(int id)
        {
            var values = ProjectManager.Tbl_Project.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditProject(Tbl_Project _Project)
        {
            var values = ProjectManager.Tbl_Project.Find(_Project.ProjectID);
            values.Image1 = _Project.Image1;
            values.ProjectName = _Project.ProjectName;
            values.Description = _Project.Description;
            ProjectManager.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProject(int id)
        {
            var values = ProjectManager.Tbl_Project.Find(id);
            ProjectManager.Tbl_Project.Remove(values);
            ProjectManager.SaveChanges();
            return RedirectToAction("Index");
        }
   
    }
}