using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poster_site.DAL.Models;

public class TopicSubscriptions : BaseEntity
{
    public int UserId { get; set; }
    public int TopicId { get; set; }

    // Navigation properties
    public ICollection<User> Users { get; set; } = new HashSet<User>();
    public ICollection<Topic> Topics { get; set; } = new HashSet<Topic>();
}
