using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.Models
{
    public class Student : Grades
    {
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Year { get; set; }
    }
}