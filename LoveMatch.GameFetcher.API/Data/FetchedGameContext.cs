using LoveMatch.GameFetcher.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LoveMatch.GameFetcher.API.Data
{
    public class FetchedGameContext : DbContext
    {
        public FetchedGameContext(DbContextOptions<FetchedGameContext> options)
            : base(options)
        {
        }

        public DbSet<FetchedGame> FetchedGames { get; set; }
    }
}
