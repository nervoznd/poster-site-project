using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poster_site.DAL.Models;

public class Topic : BaseEntity
{
    public string TopicName { get; set; }
    public string? Description { get; set; }

    // Navigation properties
    public ICollection<TopicSubscriptions> TopicSubscriptions { get; set; } = new HashSet<TopicSubscriptions>();
}
