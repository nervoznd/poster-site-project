namespace poster_site.DAL.Models;

public class Topic : BaseEntity
{
    public string TopicName { get; set; }
    public string? Description { get; set; }

    // Navigation properties
    public ICollection<TopicSubscriptions> TopicSubscriptions { get; set; } = new HashSet<TopicSubscriptions>();
}
