using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.Models
{
    public class Courses 
    {
        public string CourseID { get; set; }

        public string NameCourse { get; set; }

        public int SubjectID { get; set; }

        public string SubjectName { get; set; }

        public int NumberOfSubjects { get; set; }

        public int NumberOfTeachers { get; set; }

        public int NumberOfStudents { get; set; }

        public int GradesAverage { get; set; }


        



    }
}