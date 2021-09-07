using Newtonsoft.Json;
using Seachcourses.Entities;
using Seachcourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Seachcourses.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public async System.Threading.Tasks.Task<ActionResult> SearchCourses(int imGRE=0, decimal dmGPA = 0 , string sCountry = null,string scourseName=null)
        {
            var Udata = new UniversityCourses
            {
                country = sCountry!=null? sCountry.Trim(): sCountry,
                minimum_gpa = dmGPA,
                minimum_gre_score = imGRE,
                Coursename= scourseName
            };
            var httphandler = new Helpers.HttpcallsHandler();

             var result=  await httphandler.Post("https://localhost:44336/api/Courses/GetCoursesfilter", Udata);

     

            return View(result);
        }
    }
}
