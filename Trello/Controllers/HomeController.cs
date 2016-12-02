using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trello.Models;

namespace Trello.Controllers
{
    public class HomeController : Controller
    {

        TrelloDbContext db = new TrelloDbContext();

        public ActionResult Index()
        {

            return View(db.Cards.ToList());
        }

        [HttpPost]
        public ActionResult PostCard(string Title)
        {
            Card myCard = new Card();
            
            myCard.Title = Title;

            db.Cards.Add(myCard);
            db.SaveChanges();
           // return View();

            return RedirectToAction("Index");
        }

        
    }
}