using LiteratureSolitaire.Infrastructure.Data.Models;
using LiteratureSolitaire.Infrastructure.Data.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Infrastructure.Data
{
    public class LiteratureSolitaireDbContext : IdentityDbContext
    {
        public LiteratureSolitaireDbContext(DbContextOptions<LiteratureSolitaireDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AuthorConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());
            builder.ApplyConfiguration(new LiteraryDirectionConfiguration());
            builder.ApplyConfiguration(new WorkConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<LiteraryDirection> LiteraryDirections { get; set; }

        public DbSet<Work> Works { get; set; }
    }
}
