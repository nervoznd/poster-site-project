using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using poster_site.DAL.Models;

namespace poster_site.DAL;

public class PosterSiteDbContext : DbContext
{
    public PosterSiteDbContext(DbContextOptions<PosterSiteDbContext> options) : base(options) { }
    public DbSet<BaseMedia> BaseMedia { get; set; }
}
