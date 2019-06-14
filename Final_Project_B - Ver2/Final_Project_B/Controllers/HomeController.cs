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

        public ActionResult Multi()
        {
            Project_B_FinalEntities3 db = new Project_B_FinalEntities3();
            List<ScoreHK1> scoreHK1s = db.ScoreHK1.ToList();
            List<ScoreCN> scoreCNs = db.ScoreCNs.ToList();
            var multi = from hk1 in scoreHK1s
                        join hk2 in scoreCNs on hk1.StudentID equals hk2.StudentID into table1
                        from hk2 in table1.DefaultIfEmpty()
                        select new AllYearViewModel
                        {
                            StudentID = hk1.StudentID,
                            ClassID = hk1.ClassID,
                            LastName = hk1.LastName,
                            FirstName = hk1.FirstName,
                            TBHK1 = hk1.TBHK1,
                            TBHK2 = hk2.TBHK2,
                            TBHCN = (hk1.TBHK1 + (hk2.TBHK2) * 2) / 3
                        };

            return View(multi);
        }

        public ActionResult AddHk1()
        {
            Project_B_FinalEntities db = new Project_B_FinalEntities();
            List<ScoreHK1> scoreHK1s = db.ScoreHK1.ToList();
            return View(scoreHK1s);
        }
    }
}