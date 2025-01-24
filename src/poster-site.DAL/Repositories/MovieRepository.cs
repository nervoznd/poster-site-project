using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace poster_site.DAL.Repositories;

public class MovieRepository : Repository<Movie>, IMovieRepository
{
    public MovieRepository(PosterSiteDbContext context) : base(context) { }
}
