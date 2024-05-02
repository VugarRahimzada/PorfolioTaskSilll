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
    public class UserConfigration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                         .IsRequired()
                         .HasMaxLength(50);
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(x => x.ProfileImageUrl)
              .IsRequired()
              .HasMaxLength(250);

            builder.HasIndex(x => new { x.Id, x.isDelete })
            .IsUnique();
        }
    }
}
