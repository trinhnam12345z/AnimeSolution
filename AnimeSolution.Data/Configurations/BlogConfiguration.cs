using AnimeSolution.Data.Entities;
using AnimeSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeSolution.Data.Configurations
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.ToTable("Blogs");
            builder.HasKey(x => x.BlogID);
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Image).IsRequired(true);
            builder.Property(x => x.Description).IsRequired(true);
            builder.Property(x => x.Viewed).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.CreatedDate).IsRequired(true);
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.Tags).IsRequired(true);
        }
    }
}
