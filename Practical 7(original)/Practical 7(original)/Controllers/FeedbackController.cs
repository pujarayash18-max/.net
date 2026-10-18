using System.Collections.Generic;
using System.Web.Mvc;
using Practical_7_original_.Models;

namespace Practical_7_original_.Controllers
{
    public class FeedbackController : Controller
    {
        // 3rd - List at class level
        private static List<Feedback> feedbackList = new List<Feedback>();

        // 1st Action Method - Render View 1
        public ActionResult Index()
        {
            return View();
        }

        // 2nd Action Method - HTTP GET
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // 4th Action Method - List
        public ActionResult List()
        {
            return View(feedbackList);
        }

        // HTTP POST - Create
        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            feedbackList.Add(feedback);

            return RedirectToAction("List");
        }
    }
}