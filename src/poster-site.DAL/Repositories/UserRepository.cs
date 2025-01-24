using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace poster_site.DAL.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(PosterSiteDbContext context) : base(context) { }
}