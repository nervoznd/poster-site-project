using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;

namespace poster_site.DAL.Repositories;

public class MovieRepository : Repository<Movie>, IMovieRepository
{
    public MovieRepository(PosterSiteDbContext context) : base(context) { }
}
