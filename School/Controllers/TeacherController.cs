using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        
        public ActionResult TeacherInfo()
        {
            var teacher = new SchoolEntities();
            return View(teacher.Teacher.ToList());
        }
        
    }
}