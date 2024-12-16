using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poster_site.DAL.Models;

public class Series : Movie
{
    public int? NumberOfEpisodes { get; set; }
    public int? EpisodeDuration { get; set; }
}
