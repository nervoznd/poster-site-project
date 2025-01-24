using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;

namespace poster_site.DAL.Repositories;

public class NewsRepository : Repository<News>, INewsRepository
{
    public NewsRepository(PosterSiteDbContext context) : base(context) { }
} 
