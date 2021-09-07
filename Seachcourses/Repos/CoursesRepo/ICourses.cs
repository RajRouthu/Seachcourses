using Seachcourses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seachcourses.Repos.CoursesRepo
{
    interface ICourses
    {

        Task <List<UniversityCourses>> GetallCourses(UniversityCourses data);
    }
}
