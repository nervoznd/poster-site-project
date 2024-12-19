namespace poster_site.DAL.Models;

public class News : BaseEntity
{
    public string Title { get; set; }
    public string? Content { get; set; }
    public string? SourceURL { get; set; }
    public DateTime? PublishDate { get; set; }
    public int TopicId { get; set; }
    public int? MediaId { get; set; }

    // Navigation properties
    public Topic Topic { get; set; }
    public BaseMedia? Media { get; set; }
}
