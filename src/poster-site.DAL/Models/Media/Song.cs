namespace poster_site.DAL.Models;

public class Song : BaseMedia
{
    public string Artists { get; set; }
    public int? AlbumId { get; set; }
    public string? SpotifyURL { get; set; }

    // Navigation properties
    public Album? Album { get; set; }
}
