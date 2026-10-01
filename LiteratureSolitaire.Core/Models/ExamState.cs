namespace LiteratureSolitaire.Core.Models
{
    public class ExamState
    {
        public List<int> ExamSessionIds { get; set; } = new List<int>();

        public List<int> QuestionIds { get; set; } = new List<int>();

        public Dictionary<int, int?> SelectedAnswers { get; set; } = new Dictionary<int, int?>();

        public bool IsChecked { get; set; }
    }
}