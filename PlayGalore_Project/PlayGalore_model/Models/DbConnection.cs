using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PlayGalore_model.Models
{
    public class PlayContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Play> Plays { get; set; }
        public DbSet<Theatre> Theatres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = GaloreDatabase;");
    }
}
