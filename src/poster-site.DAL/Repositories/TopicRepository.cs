using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;

namespace poster_site.DAL.Repositories;

public class TopicRepository : Repository<Topic>, ITopicRepository
{
    public TopicRepository(PosterSiteDbContext context) : base(context) { }
}
