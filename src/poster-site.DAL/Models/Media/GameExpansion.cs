using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poster_site.DAL.Models;

public class GameExpansion : BaseMedia
{
    public int GameId { get; set; }
    public string Type { get; set; }

    // Navigation properties
    public Game Game { get; set; }
}
