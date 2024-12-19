namespace poster_site.DAL.Models;

public class TopicSubscriptions : BaseEntity
{
    public int UserId { get; set; }
    public int TopicId { get; set; }

    // Navigation properties
    public User User { get; set; }
    public Topic Topic { get; set; }
}
