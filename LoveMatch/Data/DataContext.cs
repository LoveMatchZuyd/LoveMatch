using LoveMatch.Models;
using Microsoft.EntityFrameworkCore;

namespace LoveMatch.Data
{
    //Created by B. Malasch. Edited by W. Smeets (DbSet<Admin).
    public class DataContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Game> Games { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Created by W. Smeets
        {
            modelBuilder.Entity<Member>()
                .HasOne(a => a.Admin)
                .WithMany(m => m.Members)
                .HasForeignKey(a => a.AdminId);

            modelBuilder.Entity<Game>()
                .HasOne(m => m.Member)
                .WithMany(g => g.Games)
                .HasForeignKey(m => m.MemberId);

            modelBuilder.Entity<Match>()
                .HasMany(m => m.Members)
                .WithMany(m => m.Matches);
        }
        public DbSet<LoveMatch.Models.Match> Match { get; set; } = default!;
    }
}
