using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poster_site.DAL.Models;

public class Album : BaseMedia
{
    public string Artists { get; set; }
    public string? SpotifyURL { get; set; }

    // Navigation properties
    public ICollection<Song>? Songs { get; set; } = new HashSet<Song>();
}
