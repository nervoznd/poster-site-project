using poster_site.DAL.Interfaces;
using poster_site.DAL.Models;

namespace poster_site.DAL.Repositories;

public class UserRoleRepository : Repository<UserRole>, IUserRoleRepository
{
    public UserRoleRepository(PosterSiteDbContext context) : base(context) { }
}