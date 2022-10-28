using System.ComponentModel.DataAnnotations;

namespace EazyQuiz_Server.Model
{
    public class league
    {
        [Key] public int id_league { get; set; }
        public string? l_name { get; set; }
        public int need_points { get; set; }
    }
}
