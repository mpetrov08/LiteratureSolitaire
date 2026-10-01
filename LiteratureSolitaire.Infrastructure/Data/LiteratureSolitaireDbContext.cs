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
            builder.Entity<QuestionPassage>()
                .HasKey(qp => new { qp.QuestionId, qp.PassageId });

            builder.Entity<QuestionPassage>()
                .HasOne(qp => qp.Question)
                .WithMany(q => q.QuestionPassages)
                .HasForeignKey(qp => qp.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<QuestionPassage>()
                .HasOne(qp => qp.Passage)
                .WithMany(p => p.QuestionPassages)
                .HasForeignKey(qp => qp.PassageId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ApplyConfiguration(new AuthorConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());
            builder.ApplyConfiguration(new LiteraryDirectionConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new WorkConfiguration());
            builder.ApplyConfiguration(new ExamSessionConfiguration());
            builder.ApplyConfiguration(new QuestionTypeConfiguration());
            builder.ApplyConfiguration(new QuestionConfiguration());
            builder.ApplyConfiguration(new PassageConfiguration());
            builder.ApplyConfiguration(new AnswerConfiguration());
            builder.ApplyConfiguration(new QuestionPassageConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<LiteraryDirection> LiteraryDirections { get; set; }

        public DbSet<Work> Works { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<AdditionalCard> AdditionalCards { get; set; }

        public DbSet<ExamSession> ExamSessions { get; set; }

        public DbSet<QuestionType> QuestionTypes { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }

        public DbSet<Passage> Passages { get; set; }

        public DbSet<QuestionPassage> QuestionPassages { get; set; }
    }
}
