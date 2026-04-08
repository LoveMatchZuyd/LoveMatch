using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoveMatch.Trivia.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TriviaController : ControllerBase
    {
        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        static readonly HttpClient client = new HttpClient();

        static async Task Main()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                using HttpResponseMessage response = await client.GetAsync("https://opentdb.com/api.php?amount=10");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
