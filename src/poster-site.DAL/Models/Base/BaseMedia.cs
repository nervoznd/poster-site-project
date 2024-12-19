namespace poster_site.DAL.Models;

public abstract class BaseMedia : BaseEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? ImagePath { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public bool? IsDateAccurate { get; set; }
    public bool IsReleased { get; set; }
    public string? Genres { get; set; }

    // Navigation properties
    public ICollection<News> News { get; set; } = new HashSet<News>();
    public ICollection<Poster> Posters { get; set; } = new HashSet<Poster>();
}