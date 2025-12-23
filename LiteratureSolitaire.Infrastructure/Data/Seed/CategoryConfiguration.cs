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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new SeedData();
            builder.HasData(new Category[]
            {
                data.TheNativeAndTheForeign,
                data.ThePastAndMemory,
                data.SocietyAndPower,
                data.LifeAndDeath,
                data.Nature,
                data.Love,
                data.FaithAndHope,
                data.LaborAndCreativity,
                data.ChoiceAndInnerConflict
            });
        }
    }
}
