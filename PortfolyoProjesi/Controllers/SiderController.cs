using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolyoProjesi.Models;
namespace PortfolyoProjesi.Controllers
{
    public class SiderController : Controller
    {
        PortfolioAcunMediaEntities1 db = new PortfolioAcunMediaEntities1();
        public ActionResult Index()
        {
            var values = db.Tbl_Sider.Find(1);
            return View(values);
        }
        [HttpPost]
        public ActionResult Index(Tbl_Sider _Sider)
        {
            var sider = db.Tbl_Sider.FirstOrDefault();
            if (sider != null)
            {
                sider.Title = _Sider.Title;
                sider.Description = _Sider.Description;
                sider.ImageUrl = _Sider.ImageUrl;
                db.SaveChanges();
            }
            else
            {
                db.Tbl_Sider.Add(_Sider);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}