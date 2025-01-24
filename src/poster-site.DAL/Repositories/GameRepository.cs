using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace poster_site.DAL.Repositories;

public class GameRepository : Repository<Game>, IGameRepository
{
    public GameRepository(PosterSiteDbContext context) : base(context) { }
}