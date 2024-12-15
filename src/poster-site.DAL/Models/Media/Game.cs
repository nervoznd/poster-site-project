using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poster_site.DAL.Models;

public class Game : BaseMedia
{
    public string? OfficialWebsiteURL { get; set; }
    public string? SteamPageURL { get; set; }
    public string? Developers { get; set; }
    public string? Publishers { get; set; }
    public string? Platforms { get; set; }
}
