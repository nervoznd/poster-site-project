using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;

namespace poster_site.DAL.Repositories;

public class SongRepository : Repository<Song>, ISongRepository
{
    public SongRepository(PosterSiteDbContext context) : base(context) { }
}
