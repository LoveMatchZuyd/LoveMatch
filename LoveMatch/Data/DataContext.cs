using LoveMatch.Models;
using Microsoft.EntityFrameworkCore;

namespace LoveMatch.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Game> Games { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }
    }
}
