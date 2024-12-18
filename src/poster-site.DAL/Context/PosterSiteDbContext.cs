using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using poster_site.DAL.Models;

namespace poster_site.DAL;

public class PosterSiteDbContext : DbContext
{
    public PosterSiteDbContext(DbContextOptions<PosterSiteDbContext> options) : base(options) { }
    public DbSet<BaseMedia> BaseMedias { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<GameExpansion> GameExpansions { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Series> Series { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<Poster> Posters { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Token> Tokens { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<TopicSubscriptions> TopicSubscriptions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
