using LoveMatch.GameFetcher.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LoveMatch.GameFetcher.API.Data
{
    // Created  by W. Smeets
    public class FetchedGameContext : DbContext
    {
        public FetchedGameContext(DbContextOptions<FetchedGameContext> options)
            : base(options)
        {
        }

        public DbSet<FetchedGame> FetchedGames { get; set; }
    }
}
