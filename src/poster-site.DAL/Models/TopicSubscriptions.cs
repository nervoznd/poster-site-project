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
    public User User { get; set; }
    public Topic Topic { get; set; }
}
