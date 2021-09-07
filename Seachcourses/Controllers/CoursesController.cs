using Seachcourses.Entities;
using Seachcourses.Repos.CoursesRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Seachcourses.Controllers
{
    public class CoursesController : ApiController
    {

        private readonly ICourses _repocoures = new Courses();
        [HttpGet]

       public  async Task <List<UniversityCourses>> GetallCourses(UniversityCourses data)
        {

            var result = await _repocoures.GetallCourses(data);
            return result;
        }

        [HttpPost]

        public async Task<List<UniversityCourses>> GetCoursesfilter(UniversityCourses data)
        {

            var result = await _repocoures.GetallCourses(data);

           
            return result;
        }
    }
}
