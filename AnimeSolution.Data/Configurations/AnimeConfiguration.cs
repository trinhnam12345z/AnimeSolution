using AnimeSolution.Data.Entities;
using AnimeSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeSolution.Data.Configurations
{
    public class AnimeConfiguration : IEntityTypeConfiguration<Anime>
    {
        public void Configure(EntityTypeBuilder<Anime> builder)
        {
            builder.ToTable("Animes");
            builder.HasKey(x => x.AnimeID);
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Image).IsRequired(true);
            builder.Property(x => x.Description).IsRequired(true);
            builder.Property(x => x.Time).IsRequired(true);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.CreatedDate).IsRequired(true);
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.Viewed).IsRequired().HasDefaultValue(0);
        }
    }
}
