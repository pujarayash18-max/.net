using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice_Practical__MVC_.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            Models.Course course1 = new Models.Course();
            course1.CourseID = "01CE1523";
            course1.Course_Name = ".Net";
            course1.Course_Outcomes = "Apply C# and Object-Oriented Programming concept<br>" +
                          "Develop ASP.NET applications<br>" +
                          "Apply ASP.NET MVC architecture<br>" +
                          "Implement database-driven .NET applications<br>" +
                          "Develop RESTful web APIs using ASP.NET Core";
            course1.Course_Credits = 2;
            return View("Course",course1);
        }
    }
}