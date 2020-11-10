using AnimeSolution.Data.Entities;
using AnimeSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeSolution.Data.Configurations
{
    public class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.ToTable("Abouts");
            builder.HasKey(x => x.AboutID);
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Image).IsRequired(true);
            builder.Property(x => x.Description).IsRequired(true);
            builder.Property(x => x.CreatedDate).IsRequired(true);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
