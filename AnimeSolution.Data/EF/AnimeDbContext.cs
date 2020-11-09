using AnimeSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeSolution.Data.EF
{
    public class AnimeDbContext : DbContext
    {
        public AnimeDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Anime> Animes { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
