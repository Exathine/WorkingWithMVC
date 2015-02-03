using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkingWithMVC.Models;

namespace WorkingWithMVC.Controllers
{
    public class Demo1Controller : Controller
    {
        //
        // GET: /Demo1/
        public ActionResult Index()
        {
            return View();
        }

        public string Action1()
        {
            return "Sample string returned by Action1() in Demo1Controller.cs";
        }
        public ActionResult Action2()
        {
            ViewBag.Paragraph = "Paragraph from Action2() in Demo1Controller.cs";
            return View();
        }
        public ActionResult Action3()
        {
            ViewBag.Message = "Action3() from Demo1Controller.cs message to View";
            return View();
        }
        public ActionResult Action4()
        {
            ViewData["Message"] = "Action4() in Demo1Controller.cs";
            ViewData["CurrentDate"] = DateTime.Now.Date;
            ViewData["CurrentTime"] = DateTime.Now.TimeOfDay;
            return View();
        }
        public ActionResult Action5()
        {
            ViewBag.Message = "Action5() in Demo1Controller.cs -> View has its own model (Bad practice)";
            return View();
        }
        public ActionResult Action6()
        {
            ViewBag.Message = "Action 6 prepare and provide model to view";

            MemberInfo m = new MemberInfo();
            m.ID = "1";
            m.Name = "Chris";
            m.Type = "Administrator";
            m.Contact.Address = "1234 Main St.";
            m.Contact.City = "Brampton";
            m.Contact.Email = "mauricic@sheridancollege.ca";

            return View(m);
        }
        public ActionResult Action7()
        {
            ViewBag.Message = "Action7() in Demo1Controller.cs -> Returns a list of members";

            List<MemberInfo> MemberAddressBook = new List<MemberInfo>();

            MemberAddressBook.Add(new MemberInfo()
            {
                ID = "1",
                Name = "Joe",
                Type = "Sales",
                Contact =
                {
                    Address = "555 Flower Rd.",
                    City = "Brampton",
                    Email = "Joe@sheridancollege.ca"
                }
            });

            MemberAddressBook.Add(new MemberInfo()
            {
                ID = "2",
                Name = "Steve",
                Type = "Finance",
                Contact =
                {
                    Address = "3244 Sunflower Rd.",
                    City = "Brampton",
                    Email = "Steve03@sheridancollege.ca"
                }
            });
            return View(MemberAddressBook);
        }
        public ActionResult Action8()
        {
            ViewBag.Message = "Action8() in Demo1Controller.cs";
            MemberInfo m = new MemberInfo();
            m.ID = "1";
            m.Name = "Chris";
            m.Type = "Gold";
            m.Contact.Address = "1234 Main St.";
            m.Contact.City = "Brampton";
            m.Contact.Email = "mauricic@sheridancollege.ca";

            GameInfo g1 = new GameInfo();
            g1.Title = "GTA5";
            g1.Price = "$69.99";

            GameInfo g2 = new GameInfo();
            g2.Title = "Candy Crush";
            g2.Price = "$0.99";

            NewArrivalVM NewArrival = new NewArrivalVM();
            NewArrival.Member = m;
            NewArrival.Games.Add(g1);
            NewArrival.Games.Add(g2);

            return View(NewArrival);
        }
    }
}