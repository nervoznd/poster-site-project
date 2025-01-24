using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;

namespace poster_site.DAL.Repositories;

public class TokenRepository : Repository<Token>, ITokenRepository
{
    public TokenRepository(PosterSiteDbContext context) : base(context) { }
}