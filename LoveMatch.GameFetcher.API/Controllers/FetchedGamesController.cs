using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LoveMatch.GameFetcher.API.Data;
using LoveMatch.GameFetcher.API.Models;

namespace LoveMatch.GameFetcher.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FetchedGamesController : ControllerBase
    {
        private readonly FetchedGameContext _context;

        public FetchedGamesController(FetchedGameContext context)
        {
            _context = context;
        }

        // GET: api/FetchedGames
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FetchedGame>>> GetFetchedGames()
        {
            return await _context.FetchedGames.ToListAsync();
        }

        // GET: api/FetchedGames/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FetchedGame>> GetFetchedGameById(int id)
        {
            var fetchedGame = await _context.FetchedGames.FindAsync(id);

            if (fetchedGame == null)
            {
                return NotFound();
            }

            return fetchedGame;
        }

    }
}
