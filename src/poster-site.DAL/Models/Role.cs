namespace poster_site.DAL.Models;

public class Role : BaseEntity
{
    public string RoleName { get; set; }

    // Navigation properties
    public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
}
