using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using TP1DsvAspNet.Domain;
using TP1DsvAspNet.Repository.Mapping;

namespace TP1DsvAspNet.Repository.Context
{
    public class FriendContext : DbContext
    {
        public DbSet<Friend> Friends { get; set; }

        public static readonly ILoggerFactory _loggerFactory =
            LoggerFactory.Create(builder => { builder.AddConsole(); });
        
        public FriendContext(DbContextOptions<FriendContext> options) : base(options) 
        { 
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(_loggerFactory);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FriendMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
