using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace poster_site.DAL.Repositories;

public class SongRepository : Repository<Song>, ISongRepository
{
    public SongRepository(PosterSiteDbContext context) : base(context) { }
}
