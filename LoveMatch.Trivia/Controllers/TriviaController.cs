using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

// Created by W. Smeets
namespace LoveMatch.Trivia.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TriviaController : ControllerBase
    {
        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        static readonly HttpClient client = new HttpClient();


        [HttpGet]

        public async Task<JsonDocument> GetTriviaQuestions()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                using HttpResponseMessage response = await client.GetAsync("https://opentdb.com/api.php?amount=1");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JsonDocument responseJson = JsonDocument.Parse(responseBody);

                return responseJson;
            }
            catch (Exception)
            {
                string error = new string("Onze excuses. Er ging iets mis");
                JsonDocument errorJson = JsonDocument.Parse(error);
                return errorJson;
            }
        }
    }
}
