using System.ComponentModel.DataAnnotations;

namespace EazyQuiz_Server.Model
{
    public class user_info
    {
        [Key] public int id_user { get; set; }
        public string? login { get; set; }
        public string? password { get; set; }
        public string? email { get; set; }
        public string? username { get; set; }
        public int age { get; set; }
        public string? gender { get; set; }
        public int points { get; set; }
        public int day_streak { get; set; }
        public string? image_url { get; set; }
        public string? country { get; set; }
        public int id_league { get; set; }
    }
}
