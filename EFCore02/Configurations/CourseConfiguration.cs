using EFCore02.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(C => C.Id);
            builder.Property(C => C.Id)
                   .UseIdentityColumn(10, 10);

            builder.Property(C => C.Name)
                 .HasColumnType("varchar")
                 .HasMaxLength(50);

            builder.Property(C => C.Description)
                   .HasColumnType("varchar")
                   .HasMaxLength(200);
        }
    }
}
