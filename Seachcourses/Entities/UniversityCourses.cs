using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seachcourses.Entities
{
    public class UniversityCourses
    {

        public long id { get; set; }
        public long university_id { get; set; }
        public string Universityname { get; set; }
        public string Coursename { get; set; }
        public string teacher_name { get; set; }
        public decimal? minimum_gpa { get; set; }
        public int?  minimum_gre_score { get; set; }
        public string country { get; set; }

    }
}