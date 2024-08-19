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
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors");
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id)
                   .UseIdentityColumn(10, 10);

            builder.Property(I => I.Name)
                   .HasMaxLength(50);

            builder.Property(I => I.Salary)
                   .HasPrecision(18, 2);

            builder.Property(I => I.Address)
                   .IsRequired(false)
                   .HasMaxLength(100);

            builder.Property(I => I.Bonus)
                   .HasPrecision(18, 2);
        }
    }
}
