using Seachcourses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Seachcourses.Repos.CoursesRepo
{
    public class Courses : ICourses
    {
        private CoursesContext _context;
        public async Task <List<UniversityCourses>> GetallCourses(UniversityCourses data)
        {
           using(_context=new CoursesContext())
            {

                try
                {
                    IQueryable<UniversityCourses> obj;
                    obj = from uni in _context.Universites.AsNoTracking() join
                             courses in _context.Coures on uni.id equals courses.university_id into
                             unicoursesdefault
                          from _unicoursesdefault in unicoursesdefault.DefaultIfEmpty() where uni.minimum_gre_score>= data.minimum_gre_score && uni.minimum_gpa>= data.minimum_gpa
                          select new UniversityCourses
                          {
                              Coursename = _unicoursesdefault != null ? _unicoursesdefault.name : "",
                              Universityname = uni.name,
                              country = uni.country,
                              teacher_name = _unicoursesdefault != null ? _unicoursesdefault.teacher_name : "",
                              minimum_gpa = uni.minimum_gpa,
                              minimum_gre_score = uni.minimum_gre_score

                              };
                  if(data.country!=null)
                    {
                        obj = obj.Where(cout => cout.country.Trim() == data.country);
                    }
                   


                    if(data.Coursename!= "" &&data.Coursename!=null)
                    {
                        string[] filters = data.Coursename.Split(new[] { ' ' });
                        obj = from finalobj in obj
                              where filters.All(f => finalobj.Coursename.Contains(f))
                              select finalobj;
                            
                    }

                    return obj.ToList();
                }
                catch(Exception ex)
                {
                    return null;

                }
            }
        }
    }
}