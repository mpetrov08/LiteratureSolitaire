using System.Text.Json;
using System.Text.Json.Serialization;
using LiteratureSolitaire.Infrastructure.Data.Models;

namespace LiteratureSolitaire.Infrastructure.Data.Seed
{
    public class SeedExamData
    {
        public List<Passage> Passages { get; set; } = new List<Passage>();
        public List<Question> Questions { get; set; } = new List<Question>();
        public List<Answer> Answers { get; set; } = new List<Answer>();
        public List<ExamSession> ExamSessions { get; set; } = new List<ExamSession>();
        public List<QuestionType> QuestionTypes { get; set; } = new List<QuestionType>();
        public List<QuestionPassage> QuestionPassages { get; set; } = new List<QuestionPassage>();

        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter() }
        };

        private static readonly Lazy<SeedExamData> _instance = new Lazy<SeedExamData>(Load);

        public static SeedExamData Instance => _instance.Value;

        private static SeedExamData Load()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "Seed", "exam-data.json");

            string json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<SeedExamData>(json, Options)
                   ?? new SeedExamData();
        }
    }
}