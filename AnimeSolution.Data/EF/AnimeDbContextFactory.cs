using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AnimeSolution.Data.EF
{
    public class AnimeDbContextFactory : IDesignTimeDbContextFactory<AnimeDbContext>
    {
        public AnimeDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var connectionString = configuration.GetConnectionString("AnimeSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<AnimeDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new AnimeDbContext(optionsBuilder.Options);
        }
    }
}
