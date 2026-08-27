using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice_Practical__MVC_.Models
{
    public class Course
    {
        public string CourseID { get; set; }
        public string Course_Name { get; set; }
        public string Course_Outcomes { get; set; }
        public int Course_Credits { get; set; }
        public Course() { }
    }
}