using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;

namespace poster_site.DAL.Repositories;

public class GameRepository : Repository<Game>, IGameRepository
{
    public GameRepository(PosterSiteDbContext context) : base(context) { }
}