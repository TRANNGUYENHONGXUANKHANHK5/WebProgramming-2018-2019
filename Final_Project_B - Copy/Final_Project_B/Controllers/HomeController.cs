using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final_Project_B.Models;

namespace Final_Project_B.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Default()
        {
            return View();
        }

        public ActionResult Score()
        {
            Project_B_FinalEntities db = new Project_B_FinalEntities();
            List<ScoreHK1> scoreHK1s = db.ScoreHK1.ToList();
            return View(scoreHK1s);
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            Project_B_FinalEntities db = new Project_B_FinalEntities();
            ScoreHK1 hK1 = db.ScoreHK1.Where(x => x.StudentID == id).FirstOrDefault();
            return View(hK1);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ScoreHK1 scoreHK1)
        {

            if (ModelState.IsValid)
            {
                Project_B_FinalEntities db = new Project_B_FinalEntities();
                db.Entry(scoreHK1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Score");
            }
            return View(scoreHK1);
        }

        public ActionResult ScoreHk2()
        {
            Project_B_FinalEntities2 db = new Project_B_FinalEntities2();
            List<ScoreCN> scoreCNs = db.ScoreCNs.ToList();
            return View(scoreCNs);
        }

        [HttpGet]
        public ActionResult Edit2(string id)
        {
            Project_B_FinalEntities2 db = new Project_B_FinalEntities2();
            ScoreCN hK1 = db.ScoreCNs.Where(x => x.StudentID == id).FirstOrDefault();
            return View(hK1);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit2(ScoreCN scoreCN)
        {

            if (ModelState.IsValid)
            {
                Project_B_FinalEntities2 db = new Project_B_FinalEntities2();
                db.Entry(scoreCN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ScoreHk2");
            }
            return View(scoreCN);
        }
    }
}