using AnimeSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeSolution.Data.Configurations
{
    public class AnimeInCategoryConfiguration : IEntityTypeConfiguration<AnimeInCategory>
    {
        public void Configure(EntityTypeBuilder<AnimeInCategory> builder)
        {
            builder.HasKey(t => new { t.CategoryID, t.AnimeID });
            builder.ToTable("AnimeInCategories");
            builder.HasOne(t => t.Anime).WithMany(pc => pc.AnimeInCategories).HasForeignKey(pc => pc.AnimeID);
            builder.HasOne(t => t.Category).WithMany(pc => pc.AnimeInCategories).HasForeignKey(pc => pc.CategoryID);
        }
    }
}
