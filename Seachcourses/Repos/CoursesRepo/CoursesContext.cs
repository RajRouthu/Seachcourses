using Seachcourses.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seachcourses.Repos.CoursesRepo
{
    public class CoursesContext :BaseContext<CoursesContext>
    {
        public DbSet<CoursesModel> Coures { get; set; }

        public DbSet<UniversitesModel> Universites { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CoursesModelmap());

            modelBuilder.Configurations.Add(new UniversitesModelMap());
        }
    }
}