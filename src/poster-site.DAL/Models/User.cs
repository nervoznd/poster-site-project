using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poster_site.DAL.Models;

public class User : BaseEntity
{
    public string UserName { get; set; }
    public string PasswordHash { get; set; }
    public string? TelegramUserName { get; set; }
    public int TokenId { get; set; }

    // Navigation properties
    public ICollection<TopicSubscriptions> TopicSubscriptions { get; set; } = new HashSet<TopicSubscriptions>();
    public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    public Token Token { get; set; }
}
