using System.ComponentModel.DataAnnotations;

namespace EazyQuiz_Server.Model
{
    public class questions
    {
        [Key] public int id_question { get; set; }
        public string? q_text { get; set; }
        public int points { get; set; }
        public int id_theme { get; set; }
    }
}
