using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seachcourses.Models
{
    public class CoursesModel
    {

        public long id { get; set; }
        public long university_id { get; set; }
        public string name { get; set; }
        public string teacher_name { get; set; }


    }
}