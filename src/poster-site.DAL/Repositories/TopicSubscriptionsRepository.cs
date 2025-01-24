using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;

namespace poster_site.DAL.Repositories;

public class TopicSubscriptionsRepository : Repository<TopicSubscriptions>, ITopicSubscriptionsRepository
{
    public TopicSubscriptionsRepository(PosterSiteDbContext context) : base(context) { }
}