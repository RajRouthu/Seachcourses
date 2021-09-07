using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Seachcourses.Models
{
    public class UniversitesModelMap: EntityTypeConfiguration<UniversitesModel>


    {
        public  UniversitesModelMap ()
        {

            //primary key
            this.HasKey(t => new { t.id });
            //properties

            this.Property(t => t.id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(t => t.name).HasMaxLength(50);
            this.Property(t => t.country).HasMaxLength(10);
            this.Property(t => t.description).HasMaxLength(100);
            this.Property(t => t.country).HasMaxLength(10);


            //table  and columns mappings
            this.ToTable("Universities");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.minimum_gpa).HasColumnName("minimum_gpa");
            this.Property(t => t.minimum_gre_score).HasColumnName("minimum_gre_score");

        }
    }
}