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
    public class LiteraryDirectionConfiguration : IEntityTypeConfiguration<LiteraryDirection>
    {
        public void Configure(EntityTypeBuilder<LiteraryDirection> builder)
        {
            var data = new SeedData();

            builder.HasData(new LiteraryDirection[]
            {
                data.Realism,
                data.Romanticism,
                data.MagicalRealism,
                data.SocialRealism,
                data.Individualism,
                data.Symbolism,
                data.Diabolism,
                data.Existentialism,
                data.Modernism,
            });
        }
    }
}
