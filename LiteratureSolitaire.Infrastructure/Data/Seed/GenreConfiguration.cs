using LiteratureSolitaire.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Infrastructure.Data.Seed
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            var data = new SeedData();

            builder.HasData(new Genre[]
            {
                data.Novel,
                data.Feuilleton,
                data.SatiricalComedy,
                data.Ode,
                data.Poem,
                data.ShortStory,
                data.Satire,
                data.ShortNovel,
                data.PantheisticPoem,
                data.EpicPoem,
                data.LyricalMiniature,
                data.Elegy
            });
        }
    }
}
