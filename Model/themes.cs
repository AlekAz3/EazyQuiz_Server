using System.ComponentModel.DataAnnotations;

namespace EazyQuiz_Server.Model
{
    public class themes
    {
        [Key] public int id_theme { get; set; }
        public string? t_name { get; set; }
    }
}
