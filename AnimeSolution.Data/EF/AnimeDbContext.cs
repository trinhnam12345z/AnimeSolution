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
        public DbSet<About> Abouts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Slide> Slides { get; set; }
    }
}
