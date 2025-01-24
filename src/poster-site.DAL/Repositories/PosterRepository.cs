using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;

namespace poster_site.DAL.Repositories;

public class PosterRepository : Repository<Poster>, IPosterRepository 
{
    public PosterRepository(PosterSiteDbContext context) : base(context) { }
}
