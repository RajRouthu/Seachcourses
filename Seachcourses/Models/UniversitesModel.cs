using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seachcourses.Models
{
    public class UniversitesModel
    {
        public  long id { get; set; }
        public string name { get; set; }

        public string country { get; set; }

        public string description { get; set; }

        public decimal? minimum_gpa { get; set; }

        public int  minimum_gre_score { get; set; }


    }
}