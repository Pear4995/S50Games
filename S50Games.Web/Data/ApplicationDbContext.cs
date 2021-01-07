using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using S50Games.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace S50Games.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Candlestick> Candlesticks { get; set; }
        public DbSet<Stage> Stages { get; set; }
    }
}
