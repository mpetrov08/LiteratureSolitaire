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
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            var data = new SeedData();

            builder.HasData(new Author[] 
            {
                data.DimitarTalev, 
                data.AlekoKonstantinov, 
                data.StanislavStratiev,
                data.IvanVazov, 
                data.NikolaVaptsarov, 
                data.YordanRadichkov,
                data.HristoBotev,
                data.ElinPelin,
                data.HristoSmirnenski,
                data.EmilianStanev,
                data.PeyoYavorov,
                data.PenchoSlaveykov,
                data.DimichoDebelyanov,
                data.HristoFotev,
                data.PetyaDubarova,
                data.AtanasDalchev,
                data.YordanYovkov,
                data.ViktorPaskov,
                data.ElisavetaBagryana,
                data.BorisHristov
            });
        }
    }
}
