namespace poster_site.DAL.Models;

public class Movie : BaseMedia
{
    public string? Country { get; set; }
    public string? Directors { get; set; }
    public string? Writers { get; set; }
    public int? Budget { get; set; }
    public int? AgeRating { get; set; }
}
