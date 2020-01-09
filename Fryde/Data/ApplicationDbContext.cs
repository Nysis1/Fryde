using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Fryde.Models;

namespace Fryde.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Fryde.Models.Music> Music { get; set; }
        public DbSet<Fryde.Models.Playlist> Playlist { get; set; }
    }
}
