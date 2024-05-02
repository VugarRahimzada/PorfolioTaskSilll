using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PorfolioTask.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioTask.DataAccessLayer.Configration
{
    public class BlogConfigration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.Description)
             .IsRequired()
             .HasMaxLength(12000);
            builder.Property(x => x.Writer)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.ImageUrl)
                .IsRequired()
                .HasMaxLength(250);
            builder.HasIndex(x => new { x.Id, x.isDelete })
              .IsUnique();
            //builder.HasIndex(x=>x.Comment)
               
            //    (x=>x.Comment);
        }
    }




}
