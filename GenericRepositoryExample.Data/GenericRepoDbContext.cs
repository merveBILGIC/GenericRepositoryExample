﻿using GenericRepositoryExample.Core.Models;
using GenericRepositoryExample.Data.Configs;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryExample.Data
{
    public class GenericRepoDbContext : DbContext
    {
        public GenericRepoDbContext(DbContextOptions<GenericRepoDbContext> options) : base(options)
        {
        }

        public DbSet<Music> Musics { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<UsersAuthor> usersAuthors {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfig());
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new MusicConfiguration());

            modelBuilder.Seed();
        }
    }
}
