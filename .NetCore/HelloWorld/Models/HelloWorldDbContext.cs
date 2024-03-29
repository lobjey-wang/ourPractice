﻿using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Models
{
    public class HelloWorldDbContext : DbContext
    {
        public HelloWorldDbContext()
        {
        }

        public HelloWorldDbContext(DbContextOptions<HelloWorldDbContext> options)
            : base(options)
        {
        }

        public DbSet<BasketballPlayer> BasketballPlayer { get; set; }

        public DbSet<BasketballTeam> BasketballTeam { get; set; }
    }
}
