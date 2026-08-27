using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice_Practical__MVC_.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Models.Student s1= new Models.Student();
            s1.StudentID = 1;
            s1.Name = "Yash Pujara";
            s1.Description = "Testing for MVC Project";
            s1.PhoneNo = "1234567890";
            return View("Student",s1);
        }
       

    }
}