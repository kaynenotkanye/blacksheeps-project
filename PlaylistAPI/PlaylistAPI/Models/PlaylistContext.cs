using System;
using Microsoft.EntityFrameworkCore;

namespace PlaylistAPI.Models
{
    public class PlaylistContext : DbContext
    {
        public PlaylistContext(DbContextOptions opts) : base(opts){}

        public DbSet<Playlist> Playlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           //Database.EnsureCreated();
        }
    }
}
