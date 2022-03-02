using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        //[HttpPost]
        //public ActionResult Index()
        //{
        //    SchoolEntities SE = new SchoolEntities();

        //        var fjhf = (from p in SE.Courses
        //                    join sb in SE.Subject on p.ID equals sb.CourseID
        //                    join g in SE.Grades on sb.ID equals g.SubjectID
        //                    join s in SE.Student on g.StudentID equals s.ID
        //                    join t in SE.Teacher on sb.TeacherID equals t.ID
        //                    group p by p.Name into nameof
        //                    select new
        //                    {
        //                        NameCourse = nameof,
        //                        NumberOfSubjects = (from sb in SE.Subject select sb.ID).Distinct().Count(),
        //                        NumberOfTeachers = (from t in SE.Teacher select t.Name).Distinct().Count(),
        //                        NumberOfStudents = (from s in SE.Student select s.Name).Distinct().Count(),
        //                        GradesAverage = (from g in SE.Grades select g.Classification).Average()
        //                    }).ToList();



        //    return View(fjhf);


        //}

        //public ActionResult NewCoursesAction()
        //{
        //    List<Courses> black = new List<Courses>();
        //    DbCommand cmd;
        //    DbDataReader rdr;




        //    return View();
        //}

        //public ActionResult List()
        //{
        //    var list = new SchoolEntities();
        //    return View(list.CoursesResume().ToList());
        //}


        //public ActionResult Index(string id)
        //{

        //    using (var db = new SchoolEntities())
        //    {
        //        db.Database.Initialize(force: false);

        //        var cmd = db.Database.Connection.CreateCommand();
        //        cmd.CommandText = "[dbo].CoursesResume";



        //            db.Database.Connection.Open();

        //            var reader = cmd.ExecuteReader();




        //    }
        //    return View();
        //}



        public ActionResult Index()
        {
            var courses = new SchoolEntities();
            return View(courses.Courses.ToList());
            
        }

        public ActionResult Subject()
        {
            var subject = new SchoolEntities();
            return View(subject.Subject.ToList());

        }
    }
}