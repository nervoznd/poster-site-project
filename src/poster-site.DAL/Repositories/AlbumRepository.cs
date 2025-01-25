using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;

namespace poster_site.DAL.Repositories;

public class AlbumRepository : Repository<Album>, IAlbumRepository
{
    public AlbumRepository(PosterSiteDbContext context) : base(context) { }
}