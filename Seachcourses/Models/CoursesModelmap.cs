using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Seachcourses.Models
{
    public class CoursesModelmap: EntityTypeConfiguration<CoursesModel>
    {
        public  CoursesModelmap()
        {

            //primary key
            this.HasKey(t => new { t.id });
            //properties

            this.Property(t => t.id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(t => t.name).HasMaxLength(50);
            this.Property(t => t.teacher_name).HasMaxLength(50);

            //table  and columns mappings
            this.ToTable("Courses");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.teacher_name).HasColumnName("teacher_name");
            this.Property(t => t.university_id).HasColumnName("university_id");

        }
    }
}