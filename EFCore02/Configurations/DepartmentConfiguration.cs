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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");
            builder.HasKey(D => D.Dept_Id);
            builder.Property(D => D.Dept_Id).UseIdentityColumn(10, 10);

            builder.Property(D => D.Name)
                   .HasColumnName("DepartmentName")
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(D => D.HiringDate)
                    .HasDefaultValue(DateTime.Now);
        }
    }
}
