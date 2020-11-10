using AnimeSolution.Data.Entities;
using AnimeSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeSolution.Data.Configurations
{
    public class FeedbackConfiguration : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(EntityTypeBuilder<Feedback> builder)
        {
            builder.ToTable("Feedbacks");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Phone).IsRequired(true);
            builder.Property(x => x.Email).IsRequired().IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.Content).IsRequired(true);
            builder.Property(x => x.Address).IsRequired(true);
            builder.Property(x => x.CreatedDate).IsRequired(true);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);

        }
    }
}
