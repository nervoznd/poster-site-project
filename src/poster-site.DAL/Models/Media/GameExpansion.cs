namespace poster_site.DAL.Models;

public class GameExpansion : BaseMedia
{
    public int GameId { get; set; }
    public string Type { get; set; }

    // Navigation properties
    public Game Game { get; set; }
}
