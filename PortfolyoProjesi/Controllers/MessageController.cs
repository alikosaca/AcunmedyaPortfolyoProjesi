using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolyoProjesi.Controllers;
using PortfolyoProjesi.Models;
namespace PortfolyoProjesi.Controllers
{
    public class MessageController : Controller
    {
        PortfolioAcunMediaEntities1 db = new PortfolioAcunMediaEntities1();

        public ActionResult Index()
        {
            var messages = db.Tbl_Message.ToList();
            
            return View(messages);
        }
        public ActionResult NewMessage()
        {
            var messages = db.Tbl_Message.Where(m => m.Isactive == 1).ToList();

            return View(messages);
        }
        public ActionResult OldMessage()
        {
            var messages = db.Tbl_Message.Where(m => m.Isactive == 0).ToList();

            return View(messages);
        }
        public ActionResult DeleteMessage(int id)
        {
            var message = db.Tbl_Message.Find(id);
            db.Tbl_Message.Remove(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}