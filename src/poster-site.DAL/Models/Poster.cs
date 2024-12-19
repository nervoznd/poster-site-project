namespace poster_site.DAL.Models;

public class Poster : BaseEntity
{
    public string Title { get; set; }
    public string? Description { get; set; }
    public string? ImagePath { get; set; }
    public int BaseMediaId { get; set; }

    // Navigation properties
    public BaseMedia BaseMedia { get; set; }
}
