using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace poster_site.DAL.Repositories;

public class AlbumRepository : Repository<Album>, IAlbumRepository
{
    public AlbumRepository(PosterSiteDbContext context) : base(context) { }
}