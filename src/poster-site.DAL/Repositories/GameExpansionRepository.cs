using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;

namespace poster_site.DAL.Repositories;

public class GameExpansionRepository : Repository<GameExpansion>, IGameExpansionRepository
{
    public GameExpansionRepository(PosterSiteDbContext context) : base(context) { }
}