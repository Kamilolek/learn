using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace learn
{
    public class MMContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public MMContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<User> users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
