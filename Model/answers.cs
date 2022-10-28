using System.ComponentModel.DataAnnotations;

namespace EazyQuiz_Server.Model
{
    public class answers
    {
        [Key] public int id_answer { get; set; }
        public string? a_text { get; set; }
        public bool is_correct { get; set; }
        public int id_question { get; set; }
    }
}
