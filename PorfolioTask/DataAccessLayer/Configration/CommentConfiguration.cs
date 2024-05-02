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
    public class CommentConfigration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Message)
                .IsRequired()
                .HasMaxLength(2000);
            builder.HasIndex(x => new { x.Id, x.isDelete })
              .IsUnique();
        }
    }




}
