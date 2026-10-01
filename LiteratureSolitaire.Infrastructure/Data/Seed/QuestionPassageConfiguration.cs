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
    public class QuestionPassageConfiguration : IEntityTypeConfiguration<QuestionPassage>
    {
        public void Configure(EntityTypeBuilder<QuestionPassage> builder)
        {
            builder.HasData(SeedExamData.Instance.QuestionPassages);
        }
    }
}
