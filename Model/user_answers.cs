using System.ComponentModel.DataAnnotations;

namespace EazyQuiz_Server.Model
{
    public class user_answers
    {
        [Key] public int id { get; set; }
        public int id_user { get; set; }
        public int id_answer { get; set; }
        public int id_question { get; set; }
    }
}
