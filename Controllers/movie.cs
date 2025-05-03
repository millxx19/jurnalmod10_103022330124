namespace jurnalmod10_103022330124.Controllers
{
    public class movie
    {
        public string title { get; set; }
        public string director { get; set; }
        public List<string> Stars { get; set; }
        public string Description { get; set; }
        public movie(string title, string director, List<string> Stars, string Description)
        {
            this.title = title;
            this.director = director;
            this.Stars = Stars;
            this.Description = Description;
        }
    }
}

