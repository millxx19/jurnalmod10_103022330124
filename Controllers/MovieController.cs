using Microsoft.AspNetCore.Mvc;

namespace jurnalmod10_103022330124.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        private static readonly List<movie> movies = new List<movie>
        {
            new movie("The Shawshank Redemption", "Frank Darabont", new List<string> { "Tim Robbins", "Morgan Freeman" , "Bob Gunton" }, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new movie("The Godfather", "Francis Ford Coppola", new List<string> { "Marlon Brando", "AI Pacino" }, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new movie("The Dark Knight", "Christopher Nolan", new List<string> { "Christian Bale", "Heath Ledger", "Aaron Eckhart" }, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
        };
        [HttpGet]
        public IEnumerable<movie> Get()
        {
            return movies;
        }
        [HttpGet("{id}")]
        public movie Get(int id)
        {
            return movies[id];
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            movies.RemoveAt(id);
        }
        [HttpPost]
        public void Post([FromBody] movie movie)
        {
            movies.Add(movie);
        }
    }
}
