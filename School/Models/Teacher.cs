using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.Models
{
    public class Teacher : Courses
    {
       public int TeacherID { get; set; }

       public string TeacherName { get; set; }

       public string Education { get; set; }
    }
}