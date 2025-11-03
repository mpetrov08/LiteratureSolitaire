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
    public class WorkConfiguration : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            var data = new SeedData();

            builder.HasData(new Work[]
            {
                data.TheIronCandlestick,
                data.BayGanyoTheJournalist,
                data.BalkanSyndrome,
                data.SaintPaisius,
                data.History,
                data.NoahsArk,
                data.TheStruggle,
                data.Andreshko,
                data.ATaleOfTheStairway,
                data.ToMyFirstLove,
                data.TheNewCemetryNearSlivnitsa,
                data.ThePeachThief,
                data.AtRilaMonastery,
                data.Hailstorm,
                data.TheLakeSleeps,
                data.IWantToRememberYouJustLikeThis,
                data.HowBeatifulYouAre,
                data.Deadication,
                data.SapsovaMound,
                data.Prayer,
                data.Faith,
                data.TheWindMill,
                data.TheSongOfTheWheels,
                data.BalladForGeorgHenig,
                data.TwoSouls,
                data.Descendant,
                data.HonestCross
            });
        }
    }
}
