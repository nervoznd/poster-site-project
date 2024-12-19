namespace poster_site.DAL.Models;

public class Series : Movie
{
    public int? NumberOfEpisodes { get; set; }
    public int? EpisodeDuration { get; set; }
}
