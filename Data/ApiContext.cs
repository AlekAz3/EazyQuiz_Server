using EazyQuiz_Server.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EazyQuiz_Server.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<answers> answers { get; set; }
        public DbSet<questions> questions { get; set; }
        public DbSet<league> league { get; set; }
        public DbSet<themes> themes { get; set; }
        public DbSet<user_answers> user_answers { get; set; }
        public DbSet<user_info> user_info { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
            
        }
    
    }
}
